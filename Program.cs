using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            #region Notes
            /*  namespace --> classes --> methods --> statements.
            each namespace, class and methods have scopes. the scope starts with '{' ends with '}' .
            The main function is the entry point of our application. 
            Main(string[] args) indicates that it is takes an input of some arguments
            void indicates that it will return nothing

            The application Video is executable, which means it can self execute.
            In this path C:\Users\maqmi\Documents\codes\Video\bin\Debug open the Video.exe file we can see the result

            What is DLL? 
            DLL stands for Dynamic Link Library which is not self Executable
            DLL cannot execute by itself .

            C# compilation is a two-step process:
            1)Compiling: In compiling phase individual C# code files are compiled into individual compiled units. 
                            These individual compiled code files go in the OBJ directory.
            2)Linking: In the linking phase these individual compiled code files are linked to create single unit DLL and EXE. 
                        This goes in the BIN directory.

            Main - main method is the starting point of the program without main program wont run.
                
            */
            #endregion

            #region Types

            #region Value Types
            //Value types and reference types are the two main categories of C# types.

            //This differs from a variable of a reference type, which contains a reference to an instance of the type.
            //By default, on assignment, passing an argument to a method, and returning a method result, variable values are copied.
            //In the case of value-type variables, the corresponding type instances are copied.

            //Value Type
            //A variable of a value type contains an instance of the type.
            //A data type is a value type if it holds a data value within its own memory space.
            //It means the variables of these data types directly contain values.
            //Value Type variables are stored in the stack and are passed by copying.


            int val_type = 10;
            //The system stores 100 in the memory space allocated for the variable i (in RAM a => 0X239110 --> 10 is stored. )
            // The following data types are all of value type:
            //bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, struct, uint, ulong, ushort

            //Passing Value Type Variables
            //When you pass a value - type variable from one method to another,
            //the system creates a separate copy of a variable in another method.
            //If value got changed in the one method, it wouldn't affect the variable in another method.

            #endregion

            #region Reference Types

            //a reference type doesn't store its value directly.
            //Instead, it stores the address where the value is being stored.
            //In other words, a reference type contains a pointer to another memory location that holds the data.
            //A reference type is stored on the heap and passed by creating a reference.
            //The default value of a reference type variable is null when they are not initialized.
            //Null means not refering to any object.

            string s = "Hello World!!";
            //In RAM s => 0x803200 --> 0x600000 (address where the value is stored)
            // 0X600000 --> Hello World!!! (Actual value)
            //The followings are reference type data types:
            //string, array, delegates, class

            //Passing Reference Type Variables
            //When you pass a reference type variable from one method to another,
            //it doesn't create a new copy; instead, it passes the variable's address.
            //If we change the value of a variable in a method, it will also be reflected in the calling method.



            #endregion

            #region  Built-in Value Types

            #region bool 
            //Boolean logical operators 

            bool a = true;
            bool b = false;
            Console.WriteLine(a ? "Checked" : "Not checked");  // output: Checked
            Console.WriteLine(b ? "Checked" : "Not checked");  // output: Not checked

            #region Unary op !
            //1. Unary ! (logical negation) operator
            //The unary prefix ! operator computes logical negation of its operand.
            //That is, it produces true, if the operand evaluates to false, and false, if the operand evaluates to true
            Console.WriteLine(!a);  // output: False
            Console.WriteLine(!b);    // output: True
            #endregion


            //2. Binary & (logical AND), | (logical OR), and ^ (logical exclusive OR) operators.
            //Those operators always evaluate both operands.

            #region Binary Logical AND op &
            //Logical AND operator &
            //The & operator computes the logical AND of its operands.
            //The result of x & y is true if both x and y evaluate to true. Otherwise, the result is false.
            bool andfirst = true & true;       // output: True
            bool andsecond = true & false;     // output: False
            bool andthird = false & true;      // output: False
            bool andfourth = false & false;    // output: False

            //The & operator evaluates both operands even if the left-hand operand evaluates to false,
            //so that the operation result is false regardless of the value of the right-hand operand.
            bool SecondOperand()
            {
                Console.WriteLine("Second operand is evaluated.");
                return true;
            }

            bool a2 = false & SecondOperand();
            // Output:
            // Second operand is evaluated.
            // False

            bool b2 = true & SecondOperand();
            // Output:
            // Second operand is evaluated.
            // True
            #endregion

            #region Logical OR op |
            //Logical OR operator |
            // The result of x | y is true if either x or y evaluates to true. Otherwise, the result is false.
            bool orfirst = true | true;       // output: True
            bool orsecond = true | false;     // output: True
            bool orthird = false | true;      // output: True
            bool orfourth = false | false;    // output: False

            //The | operator evaluates both operands even if the left-hand operand evaluates to true,
            //so that the operation result is true regardless of the value of the right-hand operand.
            bool a3 = true | SecondOperand();
            // Output:
            // Second operand is evaluated.
            // True

            bool b3 = false | SecondOperand();
            // Output:
            // Second operand is evaluated.
            // True
            #endregion

            #region Logical XOR op ^
            //Logical exclusive OR operator ^
            //The result of x ^ y is true if x evaluates to true and y evaluates to false,
            //or x evaluates to false and y evaluates to true. Otherwise, the result is false.
            bool xorfirst = true ^ true;       // output: False
            bool xorsecond = true ^ false;     // output: True
            bool xorthird = false ^ true;      // output: True
            bool xorfourth = false ^ false;    // output: False
            #endregion

            //3.Binary && (conditional logical AND) and || (conditional logical OR) operators.
            //Those operators evaluate the right-hand operand only if it's necessary.

            #region Conditional logical AND operator &&
            //The conditional logical AND operator &&, also known as the "short-circuiting" logical AND operator,
            //computes the logical AND of its operands. (same like &)
            //The result of x && y is true if both x and y evaluate to true. Otherwise, the result is false.
            bool condandfirst = true && true;       // output: True
            bool condandsecond = true && false;     // output: False 
            bool condandthird = false && true;      // output: False //second operand is not evaluated
            bool condandfourth = false && false;    // output: False //second operand is not evaluated

            //If x evaluates to false, y is not evaluated.
            bool a4 = false && SecondOperand();
            Console.WriteLine(a4);
            // Output:
            // False

            bool b4 = true && SecondOperand();
            Console.WriteLine(b4);
            // Output:
            // Second operand is evaluated.
            // True
            #endregion

            #region Conditional logical OR operator ||
            //The conditional logical OR operator ||, also known as the "short-circuiting" logical OR operator,
            //computes the logical OR of its operands. (same like ||)
            //The result of x || y is true if either x or y evaluates to true. Otherwise, the result is false.
            bool condorfirst = true || true;       // output: True  //second operand is not evaluated
            bool condorsecond = true || false;     // output: True  //second operand is not evaluated
            bool condorthird = false || true;      // output: True
            bool condorfourth = false || false;    // output: False

            //If x evaluates to true, y is not evaluated
            bool a5 = true || SecondOperand();
            Console.WriteLine(a5);
            // Output:
            // True

            bool b5 = false || SecondOperand();
            Console.WriteLine(b5);
            // Output:
            // Second operand is evaluated.
            // True
            #endregion


            //Nullable Boolean logical operators
            #region Nullable Boolean logical op
            //For bool? operands, the & (logical AND) and | (logical OR) operators support the three-valued logic as follows:
            //& op ture & null = null; false & null = false; null & null = null; 
            //| op ture & null = true; false & null = null  ; null	null = null; 

            //You can also use the ! and ^ operators with bool? operands,
            bool? test = null;
            Display(!test);         // output: null
            Display(test ^ false);  // output: null
            Display(test ^ null);   // output: null
            Display(true ^ null);   // output: null
            void Display(bool? b6) => Console.WriteLine(b6 is null ? "null" : b6.Value.ToString()); //no output
            #endregion

            #region bool conversion
            // refer https://docs.microsoft.com/en-us/dotnet/api/system.convert.toboolean?view=net-6.0
            //can convert sbyte, string, Uint, Decimal, int, Double, datetime, char, byte to boolean.
            
            #endregion

            #endregion

            #region byte & sbyte

            //Byte Struct
            //Namespace: System
            //Assembly: System.Runtime.dll
            //Represents an 8 - bit unsigned integer.
            //Inheritance --> Object --> ValueType -> Byte
            //Implements: IComparable , IComparable<Byte> , IConvertible , IEquatable<Byte> , IFormattable , ISpanFormattable
            // Byte is an immutable value type that represents unsigned integers with values that range from 0 to 255. 

            byte value1 = 64;
            byte value2 = 255;


            #region byte conversion operations
           
            //You can assign a non-byte numeric value to a byte. This is a narrowing conversion, so it requires a cast operator in C# 
            // If the non-byte value is a Single, Double, or Decimal value that includes a fractional component,
            // the handling of its fractional part depends on the compiler performing the conversion. 

            int int_by = 128;
            byte by_val1 = (byte)int_by;
            Console.WriteLine(by_val1);
            double db_by = 3.997;
            byte by_val2 = (byte)db_by;
            Console.WriteLine(by_val2);
            // The example displays the following output:
            //       128
            //       3

            //1. Using Convert class
            //You can call a method of the Convert class to convert any supported type to a Byte value.
            //This is possible because Byte supports the IConvertible interface.
            //The following example illustrates the conversion of an array of Int32 values to Byte values.

            int number = 121;
            byte result = Convert.ToByte(number);
            Console.WriteLine("Converted the {0} value {1} to the {2} value {3}.", number.GetType().Name, number,
                                      result.GetType().Name, result);
            // The example displays the following output:
            //       Converted the Int32 value 121 to the Byte value 121.

            /*******************************************************************************************************************/

            //2. Using Parse() method
            //You can call the Parse or TryParse method to convert the string representation of a Byte value to a Byte.
            //The string can contain either decimal or hexadecimal digits.
            //The following example illustrates the parse operation by using both a decimal and a hexadecimal string.

            string string1 = "244";
            byte byte1 = Byte.Parse(string1);
            Console.WriteLine(byte1);

            string string2 = "F9";
            byte byte2 = Byte.Parse(string2,System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(byte2);
            // The example displays the following output:
            //       244
            //       249
            /************************************************************************************************************/

            //1. Representing a Byte as a String Using ToString() method
            //To format a Byte value as an integral string with no leading zeros, you can call the parameterless ToString() method.
            //By using the "D" format specifier, you can also include a specified number of leading zeros in the string representation.
            //By using the "X" format specifier, you can represent a Byte value as a hexadecimal string.
            //The following example formats the elements in an array of Byte values in these three ways.

            byte[] numbers_str = { 0, 16, 104, 213 };
            foreach (byte nums in numbers_str)
            {
                // Display value using default formatting.
                Console.Write("{0,-3}  -->   ", nums.ToString());
                // Display value with 3 digits and leading zeros.
                Console.Write(nums.ToString("D3") + "   ");
                // Display value with hexadecimal.
                Console.Write(nums.ToString("X2") + "   ");
                // Display value with four hexadecimal digits.
                Console.WriteLine(nums.ToString("X4"));
            }
            // The example displays the following output:
            //       0    -->   000   00   0000
            //       16   -->   016   10   0010
            //       104  -->   104   68   0068
            //       213  -->   213   D5   00D5
            /************************************************************************************************************/

            //2. Representing a Byte as a binary, octal, decimal, or hexadecimal string by calling the ToString(Byte, Int32) method
            // supplying the base as the method's second parameter.
            // The following example calls this method to display the binary, octal, and hexadecimal representations of an array of byte values.

            byte[] numbers_bin = { 0, 16, 104, 213 };
            Console.WriteLine("{0}   {1,8}   {2,5}   {3,5}",
                              "Value", "Binary", "Octal", "Hex");
            foreach (byte numm in numbers_bin)
            {
                Console.WriteLine("{0,5}   {1,8}   {2,5}   {3,5}",
                                  numm, Convert.ToString(numm, 2),
                                  Convert.ToString(numm, 8),
                                  Convert.ToString(numm, 16));
            }
            // The example displays the following output:
            //       Value     Binary   Octal     Hex
            //           0          0       0       0
            //          16      10000      20      10
            //         104    1101000     150      68
            //         213   11010101     325      d5

            /************************************************************************************************************/

            #endregion

            #region sbyte
            //SByte
            //Definition Namespace:System
            //Assembly:System.Runtime.dll
            //Represents an 8-bit signed.
            //The SByte value type represents integers with values ranging from negative 128 to positive 127.

            sbyte val_sbytemin = -128;
            sbyte val_sbytemax = 127;

            #region sbyte conversion

            //refer https://docs.microsoft.com/en-us/dotnet/api/system.convert.tosbyte?view=net-6.0
            //can convert string, unit, single, int, byte, char, DateTime, Boolean, Decimal.
            #endregion

            #endregion

            #endregion

            #region char

            //The char type keyword is an alias for the .NET System.Char structure type that represents a Unicode UTF-16 character.
            //The default value of the char type is \0, that is, U+0000.
            //range of char U+0000 to U+FFFF	
            char chA = 'A';
            char ch1 = '1';
            string str = "test string"; //The string type represents text as a sequence of char values.

            Console.WriteLine(chA.CompareTo('B'));          //-----------  Output: "-1" (meaning 'A' is 1 less than 'B')
            Console.WriteLine(chA.Equals('A'));             //-----------  Output: "True"
            Console.WriteLine(Char.GetNumericValue(ch1));   //-----------  Output: "1"
            Console.WriteLine(Char.IsControl('\t'));        //-----------  Output: "True"
            Console.WriteLine(Char.IsDigit(ch1));           //-----------  Output: "True"
            Console.WriteLine(Char.IsLetter(','));          //-----------  Output: "False"
            Console.WriteLine(Char.IsLower('u'));           //-----------  Output: "True"
            Console.WriteLine(Char.IsNumber(ch1));          //-----------  Output: "True"
            Console.WriteLine(Char.IsPunctuation('.'));     //-----------  Output: "True"
            Console.WriteLine(Char.IsSeparator(str, 4));    //-----------  Output: "True"
            Console.WriteLine(Char.IsSymbol('+'));          //-----------  Output: "True"
            Console.WriteLine(Char.IsWhiteSpace(str, 4));   //-----------  Output: "True"
            Console.WriteLine(Char.Parse("S"));             //-----------  Output: "S"
            Console.WriteLine(Char.ToLower('M'));           //-----------  Output: "m"
            Console.WriteLine('x'.ToString());              //-----------  Output: "x"

            // You can specify a char value with: a character literal.
            // a Unicode escape sequence, which is \u followed by the four - symbol hexadecimal representation of a character code.
            // a hexadecimal escape sequence, which is \x followed by the hexadecimal representation of a character code.
            //you can also cast the value of a character code into the corresponding char value.

            var chars = new[] { 'j', '\u006A', '\x006A', (char)106, };
            Console.WriteLine(string.Join(" ", chars));  // output: j j j j
            //\u006A is a valid escape sequence, while \u06A and \u6A are not valid.
            //\x006A, \x06A, and \x6A escape sequences are valid and correspond to the same character.

            //char categories - refer https://docs.microsoft.com/en-us/dotnet/api/system.globalization.unicodecategory?view=net-6.0

            #region char conversions

            //The char type is implicitly convertible to the following integral types: ushort, int, uint, long, and ulong.
            //It's also implicitly convertible to the built-in floating-point numeric types: float, double, and decimal.
            //It's explicitly convertible to sbyte, byte, and short integral types.
            //There are no implicit conversions from other types to the char type.
            //However, any integral or floating-point numeric type is explicitly convertible to char.
            //refer https://docs.microsoft.com/en-us/dotnet/api/system.convert.tochar?view=net-6.0
            //can convert string, unit, single, int, byte, sbyte, DateTime, Boolean, Decimal.

            #endregion

            #endregion

            //Note: each C# type keyword is an alias for the corresponding .NET type.
            //The keyword and .NET type name are interchangeable.
            int alis = 123;
            System.Int32 blis = 123;
            //except nint & nuint

            #region decimal

            //Represents a decimal floating-point number.
            //The Decimal value type represents decimal numbers ranging from positive 79,228,162,514,264,337,593,543,950,335 to negative 79,228,162,514,264,337,593,543,950,335.
            //The default value of a Decimal is 0.
            //Precision 28-29 digits	
            //size 16 bytes
            //The Decimal value type is appropriate for financial calculations that require large numbers of significant integral and fractional digits and no round-off errors. 
            //The Decimal type does not eliminate the need for rounding. Rather, it minimizes errors due to rounding.
            // For example, the following code produces a result of 0.9999999999999999999999999999 instead of 1.

            decimal dividend = Decimal.One;
            decimal divisor = 3;
            // The following displays 0.9999999999999999999999999999 to the console
            Console.WriteLine(dividend / divisor * divisor);

            //The literal with the m or M suffix is of type decimal
            decimal myMoney = 3_000.5m;
            myMoney = 400.75M;

            //scientific notation
            decimal dec_sci = 1.5E6m;
            Console.WriteLine(dec_sci);  // output: 1500000

            #region decimal conversion

            //refer https://docs.microsoft.com/en-us/dotnet/api/system.convert.todecimal?view=net-6.0
            //can convert string, unit, single, int, byte, char, DateTime, Boolean, sbyte.

            #endregion

            #endregion

            #region double

            //Represents a double-precision 64-bit floating-point number with values ranging from negative 1.79769313486232e308 to positive 1.79769313486232e308.
            //precision ~15-17 digits
            //size 8 bytes	
            double douba = 12.3;
            System.Double doubb = 12.3;

            //The Double data type stores double-precision floating-point values in a 64-bit binary format,
            //Part                      Bits
            //Significand or mantissa   0 - 51
            //Exponent	                52-62
            //Sign (0 = +ve, 1 = -ve)	63

            //The literal without suffix or with the d or D suffix is of type double
            double da = 3D;
            da = 4d;
            da = 3.934_001;

            //scientific notation
            double sci_d = 0.42e2;
            Console.WriteLine(sci_d);  // output 42

            #region double conversion

            //refer https://docs.microsoft.com/en-us/dotnet/api/system.convert.todouble?view=net-6.0
            //can convert string, unit, single, int, byte, char, DateTime, Boolean, Decimal.

            #endregion
            
            #endregion

            #region float

            //Represents a single-precision  floating-point number.
            //ranges from negative 3.402823e38 to positive 3.402823e38, as well as positive or negative zero,
            //PositiveInfinity, NegativeInfinity, and not a number (NaN). 
            //It is intended to represent values that are extremely large (such as distances between planets or galaxies) or
            //extremely small (such as the molecular mass of a substance in kilograms)
            //The Single data type stores single-precision floating-point values in a 32-bit binary format, 
            //Part	                    Bits
            //Significand or mantissa	0-22
            //Exponent	                23-30
            //Sign (0 = +ve, 1 = -ve)	31

            float valfloat1 = .3333333f;
            float valfloat2 = 1.0f / 3;
            Console.WriteLine("{0:R} = {1:R}: {2}", valfloat1, valfloat2, valfloat1.Equals(valfloat2));
            // The example displays the following output:
            //        0.3333333 = 0.333333343: False

            //The literal with the f or F suffix is of type float
            float f = 3_000.5F;
            f = 5.4f;

            //scientific notation
            float sci_f = 134.45E-2f;
            Console.WriteLine(sci_f);  // output: 1.3445

            #region float conversion
            //using parse method
            string str1 = "5.682";
            string str2 = "4.137";
            float flt1 = float.Parse(str1);
            float flt2 = float.Parse(str2);
            Console.WriteLine(flt1 + flt2);

            int val1 = 1;
            float val2 = (float)val1;

            decimal val3 = 3;
            float val4 = (float)val3;
            #endregion

            #endregion

            #region int & unit

            //int (int32) is an immutable value type that represents Signed 32-bit integer.
            //ranges from -2,147,483,648 to 2,147,483,647.	
            int num1_int = 64301;
            int num2_int = 25548612;

            #region int converion
            //refer https://docs.microsoft.com/en-us/dotnet/api/system.convert.toint32?view=net-6.0
            //can convert string, unit, single, int, byte, sbyte, char, DateTime, Boolean, Decimal.

            //widening conversion
            //You can assign the value of an integer type whose range is a subset of the Int32 type.
            //This is a widening conversion that does not require a cast operator
            sbyte value1_shrt = 124;
            short value2_shrt= 1618;
            int number1_intshrt = value1_shrt;
            int number2_intshrt = value2_shrt;

            //narrowing conversion
            //You can assign the value of a numeric type whose range exceeds that of the Int32 type.
            //This is a narrowing conversion, so it requires a cast operator
            long lNumber = 163245617;
            int number1 = (int)lNumber;
            Console.WriteLine(number1);

            double dbl2 = 35901.997;
            int number2 = (int)dbl2;
            Console.WriteLine(number2);

            BigInteger bigNumber = 132451;
            int number3 = (int)bigNumber;
            Console.WriteLine(number3);

            // The example displays the following output:
            //       163245617
            //       35902
            //       132451

            //using IConvertible
            //You can call a method of the Convert class to convert any supported type to an Int32 value. 
            decimal[] values = { -1034.23m, -12m, 0m, 147m, 199.55m, 9214.16m, };
            int res_con;
            foreach (decimal value in values)
            {
                    res_con = Convert.ToInt32(value);
                    Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.",
                                      value.GetType().Name, value,
                                      result.GetType().Name, result);
            }
            // The example displays the following output:
            //    Converted the Decimal value '-1034.23' to the Int32 value -1034.
            //    Converted the Decimal value '-12' to the Int32 value -12.
            //    Converted the Decimal value '0' to the Int32 value 0.
            //    Converted the Decimal value '147' to the Int32 value 147.
            //    Converted the Decimal value '199.55' to the Int32 value 200.
            //    Converted the Decimal value '9214.16' to the Int32 value 9214.

            //using Parse
            //the string can contain either decimal or hexadecimal digits.
            string string1_intstr = "244681";
            int number1_intstr = Int32.Parse(string1_intstr);
            Console.WriteLine(number1_intstr);

            string string2_intstr = "F9A3C";
            int number2_intstr = Int32.Parse(string2_intstr, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(number2_intstr);
            // The example displays the following output:
            //       244681
            //       1022524

            //Representing an Int32 as a String
            //To format an Int32 value as an integral string with no leading zeros, you can call the parameterless ToString() method.
            //By using the "D" format specifier, you can also include a specified number of leading zeros in the string representation.
            //By using the "N" format specifier, you can include group separators and specify the number of decimal digits to appear in the string representation of the number.
            //By using the "X" format specifier, you can represent an Int32 value as a hexadecimal string

            int[] numb_strint = { -1403, 0, 169, 1483104 };
            foreach (int numbr in numb_strint)
            {
                // Display value using default formatting.
                Console.Write("{0,-8}  -->   ", numbr.ToString());
                // Display value with 3 digits and leading zeros.
                Console.Write("{0,11:D3}", numbr);
                // Display value with 1 decimal digit.
                Console.Write("{0,13:N1}", numbr);
                // Display value as hexadecimal.
                Console.Write("{0,12:X2}", numbr);
                // Display value with eight hexadecimal digits.
                Console.WriteLine("{0,14:X8}", numbr);
            }
            // The example displays the following output:
            //    -1403     -->         -1403     -1,403.0    FFFFFA85      FFFFFA85
            //    0         -->           000          0.0          00      00000000
            //    169       -->           169        169.0          A9      000000A9
            //    1483104   -->       1483104  1,483,104.0      16A160      0016A160

            //You can also format an Int32 value as a binary, octal, decimal, or hexadecimal string
            //by calling the ToString(Int32, Int32) method and supplying the base as the method's second parameter.

            int[] numbers_binint = { -146, 11043, 2781913 };
            Console.WriteLine("{0,8}   {1,32}   {2,11}   {3,10}",
                              "Value", "Binary", "Octal", "Hex");
            foreach (int numb_binint in numbers_binint)
            {
                Console.WriteLine("{0,8}   {1,32}   {2,11}   {3,10}",
                                  numb_binint, Convert.ToString(numb_binint, 2),
                                  Convert.ToString(numb_binint, 8),
                                  Convert.ToString(numb_binint, 16));
            }
            // The example displays the following output:
            //       Value                             Binary         Octal          Hex
            //        -146   11111111111111111111111101101110   37777777556     ffffff6e
            //       11043                     10101100100011         25443         2b23
            //     2781913             1010100111001011011001      12471331       2a72d9

            #endregion

            #region uint
            //Unsigned 32-bit integer
            //ranges from 0 to 4,294,967,295	
            uint num1 = 24680;
            Console.WriteLine("Type of num1: " + num1.GetType());
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("Size of a uint variable: " + sizeof(uint));
            Console.WriteLine("Min value of uint: " + uint.MinValue);
            Console.WriteLine("Max value of uint: " + uint.MaxValue);
            //Type of num1: System.UInt32
            //num1: 24680
            //Size of a uint variable: 4
            //Min value of uint: 0
            //Max value of uint: 4294967295

            #region uint conversion
            //refer https://docs.microsoft.com/en-us/dotnet/api/system.convert.touint32?view=net-6.0
            //can convert string, unit, single, int, byte, sbyte, char, DateTime, Boolean, Decimal.

            #endregion

            #endregion

            #endregion

            #region nint & nunit
            //Starting in C# 9.0, you can use the nint and nuint keywords to define native-sized integers
            //These are 32 - bit integers when running in a 32 - bit process, or 64 - bit integers when running in a 64 - bit process
            //The native-sized integer types are represented internally as the .NET types System.IntPtr and System.UIntPtr.

            /*
            Console.WriteLine($"size of nint = {sizeof(nint)}");
            Console.WriteLine($"size of nuint = {sizeof(nuint)}");

            // output when run in a 64-bit process
            //size of nint = 8
            //size of nuint = 8

            // output when run in a 32-bit process
            //size of nint = 4
            //size of nuint = 4

            Console.WriteLine($"nint.MinValue = {nint.MinValue}");
            Console.WriteLine($"nint.MaxValue = {nint.MaxValue}");
            Console.WriteLine($"nuint.MinValue = {nuint.MinValue}");
            Console.WriteLine($"nuint.MaxValue = {nuint.MaxValue}");

            // output when run in a 64-bit process
            //nint.MinValue = -9223372036854775808
            //nint.MaxValue = 9223372036854775807
            //nuint.MinValue = 0
            //nuint.MaxValue = 18446744073709551615

            // output when run in a 32-bit process
            //nint.MinValue = -2147483648
            //nint.MaxValue = 2147483647
            //nuint.MinValue = 0
            //nuint.MaxValue = 4294967295
            */

            #endregion

            #region long & ulong

            //long or int64
            //Signed 64-bit integer	
            //ranges from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807	
            long number1_lng = -64301728;
            long number2_lng = 255486129307;
            //long: the literal is suffixed by L or l.

            #region long conversion

            //widening conversion
            //You can assign the value of an integral type whose range is a subset of the Int64 type.
            //This is a widening conversion that does not require a cast operator
            sbyte value1_sbylng = 124;
            short value2_sbylng = 1618;
            int value3_sbylng = Int32.MaxValue;

            long number1_sbylng = value1_sbylng;
            long number2_sbylng = value2_sbylng;
            long number3_sbylng = value3_sbylng;

            //narrowing conversion
            ulong ulNumber_nrw = 163245617943825;
            long number1_nrw = (long)ulNumber_nrw;
            Console.WriteLine(number1_nrw);

            double dbl2_nrw = 35901.997;
            long number2_nrw = (long)dbl2_nrw;
                Console.WriteLine(number2_nrw);
            BigInteger bigNumber_nrw = (BigInteger)1.63201978555e30;
            long number3_nrw = (long)bigNumber_nrw;
            Console.WriteLine(number3_nrw);

            // The example displays the following output:
            //    163245617943825
            //    35902
            //    1,632,019,785,549,999,969,612,091,883,520 is out of range of an Int64.

            //using  Convert.ToInt64()
            decimal values_lng = 147m;
            long result_lng = Convert.ToInt64(values_lng);
            Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.",
                  values_lng.GetType().Name, values_lng,
                  result_lng.GetType().Name, result_lng);

            //using Parse()
            string string1_lng = "244681903147";
            long numbe1_lng = Int64.Parse(string1_lng);
            Console.WriteLine(numbe1_lng);

            string string2_lng = "F9A3CFF0A";
            long numbe2_lng = Int64.Parse(string2_lng, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(numbe2_lng);
            // The example displays the following output:
            //    244681903147
            //    67012198154

            //reperesenting an Int64 as a String
            long[] numbers_lngstr = { -1403, 0, 169, 1483104 };
            foreach (var number_lngstr in numbers_lngstr)
            {
                // Display value using default formatting.
                Console.Write("{0,-8}  -->   ", number_lngstr.ToString());
                // Display value with 3 digits and leading zeros.
                Console.Write("{0,8:D3}", number_lngstr);
                // Display value with 1 decimal digit.
                Console.Write("{0,13:N1}", number_lngstr);
                // Display value as hexadecimal.
                Console.Write("{0,18:X2}", number_lngstr);
                // Display value with eight hexadecimal digits.
                Console.WriteLine("{0,18:X8}", number_lngstr);
            }
            // The example displays the following output:
            //    -1403     -->      -1403     -1,403.0  FFFFFFFFFFFFFA85  FFFFFFFFFFFFFA85
            //    0         -->        000          0.0                00          00000000
            //    169       -->        169        169.0                A9          000000A9
            //    1483104   -->    1483104  1,483,104.0            16A160          0016A160

            //represnting an int64 as bin oct hex
            long[] numbers_lngbin = { -146, 11043, 2781913 };
            foreach (var number_lngbin in numbers_lngbin)
            {
                Console.WriteLine("{0} (Base 10):", number_lngbin);
                Console.WriteLine("   Binary:  {0}", Convert.ToString(number_lngbin, 2));
                Console.WriteLine("   Octal:   {0}", Convert.ToString(number_lngbin, 8));
                Console.WriteLine("   Hex:     {0}\n", Convert.ToString(number_lngbin, 16));
            }
            // The example displays the following output:
            //    -146 (Base 10):
            //       Binary:  1111111111111111111111111111111111111111111111111111111101101110
            //       Octal:   1777777777777777777556
            //       Hex:     ffffffffffffff6e
            //
            //    11043 (Base 10):
            //       Binary:  10101100100011
            //       Octal:   25443
            //       Hex:     2b23
            //
            //    2781913 (Base 10):
            //       Binary:  1010100111001011011001
            //       Octal:   12471331
            //       Hex:     2a72d9

            #endregion

            #region ulong

            //Unsigned 64-bit integer
            //ranges from 0 to 18,446,744,073,709,551,615	
            ulong num = 16446744;
            Console.WriteLine("Type of num: " + num.GetType());
            Console.WriteLine("num: " + num);
            Console.WriteLine("Size of a ulong variable: " + sizeof(ulong));
            Console.WriteLine("Min value of ulong: " + ulong.MinValue);
            Console.WriteLine("Max value of ulong: " + ulong.MaxValue);

            //Type of num: System.UInt64
            //num: 0
            //Size of a ulong variable: 8
            //Min value of ulong: 0
            //Max value of ulong: 18446744073709551615

            //ulong conversion refer https://docs.microsoft.com/en-us/dotnet/api/system.uint64?view=net-6.0
            #endregion

            #endregion


            #region short & ushort
            //short is Signed 16-bit integer
            //ranges from -32,768 to 32,767	

            short num_sht = 20200;
            Console.WriteLine("num: " + num_sht);
            Console.WriteLine("Type of num: " + num_sht.GetType());
            Console.WriteLine("Size of a short variable: " + sizeof(short));
            Console.WriteLine("Min value of short: " + short.MinValue);
            Console.WriteLine("Max value of short: " + short.MaxValue);
            Console.ReadLine();
            //num: 20200
            //Type of num: System.Int16
            //Size of a short variable: 2
            //Min value of short: -32768
            //Max value of short: 32767

            //short conversion refer https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.compilerservices.conversions.toshort?view=net-6.0

            #region ushort
            //Unsigned 16-bit integer
            //ranges from 0 to 65,535		
            ushort num_ushrt = 8765;
            Console.WriteLine("num: " + num_ushrt);

            #region ushort conversion
            //for ushort conversion refer https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.compilerservices.conversions.toushort?view=net-6.0
            #endregion

            #endregion

            #endregion

            #region enum
            //pending
            #endregion

            #region struct
            //pending
            #endregion

            #region tuple
            //pending
            #endregion

            #region Null
            //pending
            #endregion

            #endregion

            #region Built-in Reference Types

            #region Object
            //The object type is an alias for System.Object in .NET.
            //In the unified type system of C#, all types, predefined and user-defined, reference types and value types, inherit directly or indirectly from System.Object.
            //You can assign values of any type to variables of type object. Any object variable can be assigned to its default value using the literal null.

            //boxing
            //When a variable of a value type is converted to object, it is said to be boxed.
            //When the common language runtime (CLR) boxes a value type, it wraps the value inside a System.Object instance and stores it on the managed heap.
            //Boxing is implicit

            //In the following example, the integer variable i is boxed and assigned to object o.
            int i = 123;
            // The following line boxes i.
            object o = i;

            //It is also possible to perform the boxing explicitly as in the following example, but explicit boxing is never required:
            int y = 123;
            object u = (object)y;  // explicit boxing

            //Boxing a value type allocates an object instance on the heap and copies the value into the new object.
            int bx = 123;
            object obj = bx;  // Boxing copies the value of bx into object obj.
            bx = 456; // Change the value of bx.
            // The change in bx doesn't affect the value stored in obj.
            System.Console.WriteLine("The value-type value = {0}", bx); //The value-type value = 456
            System.Console.WriteLine("The object-type value = {0}", obj); //The object-type value = 123

            //unboxing
            //When a variable of type object is converted to a value type, it is said to be unboxed
            //Unboxing extracts the value type from the object.
            //unboxing is explicit.
            //The object ob can then be unboxed and assigned to integer variable aa:
            int aa = 123;      // a value type
            object ob = aa;     // boxing
            int jj = (int)ob;   // unboxing

            //An unboxing operation consists of:
            //Checking the object instance to make sure that it is a boxed value of the given value type.
            //Copying the value from the instance into the value - type variable.

            //Attempting to unbox null causes a NullReferenceException.
            //Attempting to unbox a reference to an incompatible value type causes an InvalidCastException.

            //The following example demonstrates a case of invalid unboxing and the resulting InvalidCastException.
            //Using try and catch, an error message is displayed when the error occurs.
            int z = 123;
            object ox = z;  // implicit boxing
            try
            {
                int j = (short)ox;  // attempt to unbox    //no error if we change to int j = (int)o;
                System.Console.WriteLine("Unboxing OK.");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            }
            //Specified cast is not valid. Error: Incorrect unboxing.

            #endregion

            #region string

            //The string type represents a sequence of zero or more Unicode characters.
            //string is an alias for System.String in .NET.
            //Although string is a reference type, the equality operators == and != are defined to compare the values of string objects, not references
            string stri1 = "hello";
            string stri2 = "h";
            // Append to contents of 'b'
            stri2 += "ello";
            Console.WriteLine(stri1 == stri2);
            Console.WriteLine(object.ReferenceEquals(stri1, stri2));

            //The + operator concatenates strings:
            string str_conc = "good " + "morning";

            //Strings are immutable--the contents of a string object cannot be changed after the object is created

            //The [] operator can be used for readonly access to individual characters of a string.
            //the [] operator can also be used for iterating over each character in a string
            string str_op = "test";
            char xe = str_op[2];  // xe = 's';

            //string literals
            //String literals can contain any character literal. 
            string lit1 = "\u0066"; //output: f
            string lit2 = "\n H"; //output: H
            string lit3 = "\\"; //output: \
            string lit4 = @" ""Ahoy!"" cried the captain. "; //output "Ahoy!" cried the captain.

            //Verbatim string literals start with @ 
            //The advantage of verbatim strings is that escape sequences are not processed, which makes it easy to write
            string filename1 = @"c:\documents\files\u0066.txt"; 
            string filename2 = "c:\\documents\\files\\u0066.txt"; // by using @ instead of \\ we can use \
            //     c:\documents\files\u0066.txt
            //     c:\documents\files\u0066.txt

            string s1 = "He said, \"This is the last chance\x0021\"";
            string s2 = @"He said, ""This is the last chance\x0021""";
            //don't use a regular string literal and a verbatim string literal that contain identical character sequences.
            //output:
            //     He said, "This is the last chance!"
            //     He said, "This is the last chance\x0021"

            #endregion

            #region dynamic
            //The dynamic type indicates that use of the variable and references to its members bypass compile-time type checking.
            // Instead, these operations are resolved at run time.
            //Type dynamic behaves like type object in most circumstances.

            dynamic dyn = 1;
            object objs = 1;
            // Rest the mouse pointer over dyn and obj to see their
            // types at compile time.
            Console.WriteLine(dyn.GetType());
            Console.WriteLine(objs.GetType());

            //To see the difference between dyn and obj at compile time, add the following two lines
            /***** 
             * dyn = dyn + 3;
            ***obj = obj + 3; *****/

            //A compiler error is reported for the attempted addition of an integer and an object in expression obj + 3.
            //However, no error is reported for dyn + 3.
            //The expression that contains dyn is not checked at compile time because the type of dyn is dynamic.

            #endregion

            #region void
            //pending
            #endregion

            #region var
            //pending
            #endregion

            #region unmanaged types
            //pending
            #endregion

            #region Default Values
            //pending
            #endregion


            #endregion


            #endregion

            #region Implicit Conversion & Explicit Conversion
            /* Implicit conversion -no data loss
            Explicit conversion -data loss may happen
            user - defined conversion - via user code with helper classes */

            //Implicit Conversion
            //Widening conversions involve the creation of a new value from the value of an existing type that has either a more restrictive range
            //or a more restricted member list than the target type.
            //Widening conversions cannot result in data loss (although they may result in a loss of precision). 

            /*
            Implicit numeric conversions
            The following table shows the predefined implicit conversions between the built-in numeric types:
            From	To
            sbyte	short, int, long, float, double, decimal, or nint
            byte	short, ushort, int, uint, long, ulong, float, double, decimal, nint, or nuint
            short	int, long, float, double, or decimal, or nint
            ushort	int, uint, long, ulong, float, double, or decimal, nint, or nuint
            int	    long, float, double, or decimal, nint
            uint	long, ulong, float, double, or decimal, or nuint
            long	float, double, or decimal
            ulong	float, double, or decimal
            float	double
            nint	long, float, double, or decimal
            nuint	ulong, float, double, or decimal
             */
            //Note: The implicit conversions from the supported datatype to double may cause a loss of precision,
            //but never a loss of an order of magnitude. 
            double salary_it = 23700.56;
            Console.WriteLine((int)salary_it); //output:23700

            //Any integral numeric type is implicitly convertible to any floating-point numeric type.
            //There are no implicit conversions to the byte and sbyte types. There are no implicit conversions from the double and decimal types.
            //There are no implicit conversions between the decimal type and the float or double types.
            //A value of a constant expression of type int (for example, a value represented by an integer literal) can be implicitly converted to sbyte, byte, short, ushort, uint, ulong, nint, or nuint, if it's within the range of the destination type.
            
            #endregion

            Console.Read();
        }
    }

}
