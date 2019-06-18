//-----------------------------------------------------------------------
// Author: N Ringham [P466939]
// Creation Date: 30/04/2019
// Version 1.0
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// Winforms Form class for a Calculator
    /// </summary>
    public partial class CalculatorForm : Form
    {
        private Opcodes storedBinaryOpcode = Opcodes.NoOperation;
        private Opcodes storedUnaryOpcode = Opcodes.NoOperation;
        private decimal storedNumber;
        private NumericInput numericInput = new NumericInput();
        private bool editState = false;
        private bool errorState = false;

        /// <summary>
        /// enumeration of possible operations for temporary storage
        /// </summary>
        private enum Opcodes
        {
            NoOperation = 0,
            AdditionOperation,
            SubtractionOperation,
            MultiplicationOperation,
            DivisionOperation,
            SineOperation,
            CosineOperation,
            TangentOperation,
            InverseOperation,
            SquareRootOperation,
            CubeRootOperation,
            PerformEqualsOperation,
        }

        /// <summary>
        /// Constructor - instantiates the Calculator Form control
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(ProcessKeyPress);

            numericInput.PerformClear();
        }

        /// <summary>
        /// Refreshes the display textbox with the latest number or message to display according
        /// to the current state of the calculator
        /// </summary>
        private void UpdateDisplay()
        {
            displayTextBox.Text = errorState? "invalid" :
                editState? numericInput.ToString() : storedNumber.ToString();
        }

        /// <summary>
        /// Sends input to the numeric input, takes a character which is either a digit [0-9],
        /// or a decimal point, or a character ('±' or 'n') to toggle the sign of the numeric input
        /// </summary>
        /// <param name="digitCharacter">a digit, decimal point or '±'/'n' to toggle the sign</param>
        private void AddDigitDecimalPointOrToggleSign(char digitCharacter)
        {
            if (!editState)
            {
                //allow negating the stored result
                if (!errorState && (digitCharacter == '±' || digitCharacter=='n'))
                {
                    storedNumber = Decimal.Negate(storedNumber);
                    UpdateDisplay();
                    return;
                }

                errorState = false;
                editState = true;
                numericInput.PerformClear();
            }

            if (Char.IsDigit(digitCharacter))
                numericInput.AddDigit(digitCharacter);
            else if (digitCharacter == '.')
                numericInput.AddDecimalPoint();
            else
                numericInput.ToggleSign();

            UpdateDisplay();
        }

        /// <summary>
        /// Click handler for digit buttons, deciomal point button, and the toggle sign button
        /// </summary>
        /// <param name="sender">the object that raised the event</param>
        /// <param name="eventArgs">information information describing the click event</param>
        private void ClickDigitDecimalPointOrToggleSignButton(object sender, EventArgs eventArgs)
        {
            AddDigitDecimalPointOrToggleSign((sender as Button).Text[0]);
        }

        /// <summary>
        /// Perform a clear operation. This clears the numeric input, as resets the state of the
        /// calculator. Is either equivalent to a C or a CE on a standard calculator depending on state.
        /// If a "C" clear is preformed, calling PerformClear() again without a state change will trigger
        /// a "CE" clear.
        /// </summary>
        private void PreformClear()
        {
            //works as a "CE" operation if input has already been cleared
            //or if displaying result of previous operation
            if (!editState || numericInput.QueryIfClear())
            {
                storedBinaryOpcode = Opcodes.NoOperation;
                storedUnaryOpcode = Opcodes.NoOperation;
                storedNumber = 0;
            }

            numericInput.PerformClear();
            editState = false;

            UpdateDisplay();
        }

        /// <summary>
        /// Click handler for the Clear button
        /// </summary>
        /// <param name="sender">the object that raised the event</param>
        /// <param name="eventArgs">information information describing the click event</param>
        private void ClickClearButton(object sender, EventArgs eventArgs)
        {
            PreformClear();
        }

        /// <summary>
        /// Whether a given opcode value represents a boolean operation (binary in this context
        /// means taking two operands)
        /// </summary>
        /// <param name="opcode">the opcode to query</param>
        /// <returns>whether the opcode represents a boolean operation</returns>
        private bool QueryIfBinaryOperation(Opcodes opcode)
        {
            switch (opcode)
            {
                case Opcodes.AdditionOperation:
                case Opcodes.SubtractionOperation:
                case Opcodes.MultiplicationOperation:
                case Opcodes.DivisionOperation:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Whether a given opcode value represents a boolean or an equals operation
        /// </summary>
        /// <param name="opcode">the opcode to query</param>
        /// <returns>true if the opcode was represented a binary operation, or true if 
        /// it represented an equals operation</returns>
        private bool QueryIfBinaryOrEqualsOperation(Opcodes opcode)
        {
            switch (opcode)
            {
                case Opcodes.AdditionOperation:
                case Opcodes.SubtractionOperation:
                case Opcodes.MultiplicationOperation:
                case Opcodes.DivisionOperation:
                case Opcodes.PerformEqualsOperation:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Performs the unary operation described by a given opcode value. If the opcode
        /// does not correspond to a unary operation, the operand is returned (identity function)
        /// </summary>
        /// <param name="opcode">opcode corresponding to the operation to perform</param>
        /// <param name="operand">operand value for the operation to act on</param>
        /// <returns>the result of the operation</returns>
        private decimal PerformUnaryOperation(Opcodes opcode, decimal operand)
        {
            switch (opcode)
            {
                case Opcodes.SineOperation:
                    return TrigonometricFunctions.CalculateSine(operand);
                case Opcodes.CosineOperation:
                    return TrigonometricFunctions.CalculateCosine(operand);
                case Opcodes.TangentOperation:
                    return TrigonometricFunctions.CalculateTangent(operand);
                case Opcodes.InverseOperation:
                    return AlgebraicFunctions.CalculateInverse(operand);
                case Opcodes.SquareRootOperation:
                    return AlgebraicFunctions.CalculateSquareRoot(operand);
                case Opcodes.CubeRootOperation:
                    return AlgebraicFunctions.CalculateCubeRoot(operand);
                default:
                    return operand;
            }
        }

        /// <summary>
        /// Performs the binary(2 operand) operation described by a given opcode value. If the
        /// opcode does not correspond to a binary operation, the first operand is returned
        /// (like an identity function, but only for the first operand)
        /// </summary>
        /// <param name="opcode">opcode corresponding to the operation to perform</param>
        /// <param name="firstOperand">the first operand for the operation</param>
        /// <param name="secondOperand">the second operand for the operation</param>
        /// <returns>the result of the operation</returns>
        private decimal PerformBinaryOperation(Opcodes opcode, decimal firstOperand, decimal secondOperand)
        {
            switch (opcode)
            {
                case Opcodes.AdditionOperation:
                    return ArithmeticFunctions.CalculateAddition(firstOperand, secondOperand);
                case Opcodes.SubtractionOperation:
                    return ArithmeticFunctions.CalculateSubtraction(firstOperand, secondOperand);
                case Opcodes.MultiplicationOperation:
                    return ArithmeticFunctions.CalculateMultiplication(firstOperand, secondOperand);
                case Opcodes.DivisionOperation:
                    return ArithmeticFunctions.CalculateDivision(firstOperand, secondOperand);
                default:
                    return firstOperand;
            }
        }

        /// <summary>
        /// Called when a new opcode is input, this method is responsible for processing what can be processed
        /// from the stored opcodes and values, as well as the new opcode, and if further input is required stores
        /// enough to process that later
        /// </summary>
        /// <param name="opcode">the new opcode from user input</param>
        private void ProcessPendingOperations(Opcodes opcode)
        {
            try
            {
                //horrible mess of conditions to support unary operator contextually taking it's operand
                //from the LHS or RHS."PEMDAS"/"BODMAS" not respected - this is 'like' an old fashion style of calculator

                decimal operand = numericInput.QueryIfClear() ? storedNumber : numericInput.ToDecimal();
                numericInput.PerformClear();
                if (QueryIfBinaryOrEqualsOperation(opcode))
                {
                    decimal unaryResult = PerformUnaryOperation(storedUnaryOpcode, operand);
                    storedUnaryOpcode = Opcodes.NoOperation;

                    if (storedBinaryOpcode == Opcodes.NoOperation)
                    {
                        storedNumber = unaryResult;
                    }
                    else
                    {
                        storedNumber = PerformBinaryOperation(storedBinaryOpcode, storedNumber, unaryResult);
                    }

                    storedBinaryOpcode = opcode == Opcodes.PerformEqualsOperation ? Opcodes.NoOperation : opcode;
                }
                else
                {
                    if (editState)
                    {
                        if (storedBinaryOpcode == Opcodes.NoOperation)
                        {
                            storedNumber = PerformUnaryOperation(opcode, PerformUnaryOperation(storedUnaryOpcode, operand));
                        }
                        else
                        {
                            if (storedUnaryOpcode == Opcodes.NoOperation)
                            {
                                storedNumber = PerformBinaryOperation(storedBinaryOpcode, storedNumber, PerformUnaryOperation(opcode, operand));
                            }
                            else
                            {
                                storedNumber = PerformUnaryOperation(opcode, PerformBinaryOperation(
                                    storedBinaryOpcode, storedNumber, PerformUnaryOperation(storedUnaryOpcode, operand)));
                            }

                        }
                        storedBinaryOpcode = Opcodes.NoOperation;
                        storedUnaryOpcode = Opcodes.NoOperation;
                    }
                    else
                    {
                        //store and potentially overwrite the unary op i.e. if is sin is pushed
                        //then immediately cosine (without input i.e from editMode), the latter
                        //unary operator replaces the former
                        storedUnaryOpcode = opcode;
                    }
                }

            }
            catch (Exception exception)
            {
                storedBinaryOpcode = Opcodes.NoOperation;
                storedUnaryOpcode = Opcodes.NoOperation;
                storedNumber = 0;

                numericInput.PerformClear();
                editState = false;
                errorState = true;
                UpdateDisplay();
            }

            editState = false;
            UpdateDisplay();
        }

        /// <summary>
        /// Click handler for the operation buttons. requires the opcode to be stored in the "tag" property
        /// </summary>
        /// <param name="sender">the object that raised the event</param>
        /// <param name="eventArgs">information information describing the click event</param>
        private void ClickOperationButton(object sender, EventArgs eventArgs)
        {
            ProcessPendingOperations((Opcodes)(sender as Button).Tag);
        }

        /// <summary>
        /// Handler for general keyboard input support
        /// </summary>
        /// <param name="sender">the object that raised the event</param>
        /// <param name="eventArgs">information information describing the keypress event</param>
        void ProcessKeyPress(object sender, KeyPressEventArgs eventArgs)
        {
            eventArgs.Handled = true;
            switch (eventArgs.KeyChar)
            {
                case (char)Keys.Escape:
                    PreformClear();
                    break;
                case '+':
                    ProcessPendingOperations(Opcodes.AdditionOperation);
                    break;
                case '-':
                    ProcessPendingOperations(Opcodes.SubtractionOperation);
                    break;
                case '*':
                    ProcessPendingOperations(Opcodes.MultiplicationOperation);
                    break;
                case '/':
                    ProcessPendingOperations(Opcodes.DivisionOperation);
                    break;
                case 's':
                    ProcessPendingOperations(Opcodes.SineOperation);
                    break;
                case 'c':
                    ProcessPendingOperations(Opcodes.CosineOperation);
                    break;
                case 't':
                    ProcessPendingOperations(Opcodes.TangentOperation);
                    break;
                case 'r':
                    ProcessPendingOperations(Opcodes.SquareRootOperation);
                    break;
                case 'b':
                    ProcessPendingOperations(Opcodes.CubeRootOperation);
                    break;
                case 'i':
                    ProcessPendingOperations(Opcodes.InverseOperation);
                    break;
                case '=':
                    ProcessPendingOperations(Opcodes.PerformEqualsOperation);
                    break;
                case char c when c>='0' && c<='9':
                    AddDigitDecimalPointOrToggleSign(c);
                    break;
                case '.':
                    AddDigitDecimalPointOrToggleSign('.');
                    break;
                case 'n':
                    AddDigitDecimalPointOrToggleSign('n');
                    break;
                default:
                    eventArgs.Handled = false;
                    break;
            }
        }

        /// <summary>
        /// Special handler code to intercept the enter key and prevent it triggering button presses
        /// </summary>
        /// <param name="message">the Windows Message</param>
        /// <param name="keyData">information information describing the keypress event</param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message message, Keys keyData)
        {
            if (keyData==Keys.Enter)
            {
                ProcessPendingOperations(Opcodes.PerformEqualsOperation);
                return true;
            }

            return base.ProcessCmdKey(ref message, keyData);
        }
    }
}
