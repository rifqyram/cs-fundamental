namespace dotnet_fundamental.variables;

public class DataTypes
{
    /*
     * Contoh Comment di C#
     * atau bisa dengan ( // ) -tanpa kurung
    */

    /*
     * Untuk mendeklarasikan sebuah variable di C# sama seperti di Java.
     * kita mendefinisikan data type terlebih dahulu setelah itu nama variablenya dan diakhiri dengan titik koma(;)
     *
     * eg : type variable_name
     * int number = 10;
     */

    /*
     * Data Type di C#:
     * Decimal Type: decimal
     *     decimal numberDecimal = 1000m;
     * 
     * Boolean Type: true, false
     *     bool isTrue = true;
     *     bool isFalse = false;
     *     
     * Integral Type: int, char, byte, short, long
     *     int intNumber = 10;
     *     char charType = 'a';
     *     byte byteNumber = 255;
     *     short shortNumber = 12345;
     *     long longNumber = 9223372036854775807;
     * 
     * Floating Point Type: float and double
     *     double numberDouble = 10.5;
     *     float floatNumber = 228213131341241414;
     *
     * Strings Type: string
     *     string word = "Hello World"
     *     string text = "Ini adalah string."
     * Terdapat 2 cara untuk mendeklarasikan tipe data string menggunakan System.String class atau menggunakan string keyword.
     *     String str1 = "Hello";
     *     string str2 = "Hello";
     * Untuk keduanya tidak ada perbedaan dari penggunaan keyword tersebut
     * String (capital S) is a class in the .NET framework in the System namespace. The fully qualified name is System.String.
     * Whereas, the lower case string is an alias of System.String.
     * https://www.tutorialsteacher.com/articles/difference-between-string-and-string-in-csharp
     *
     * Special Characters: karena string menggunakan petik dua/double quotes ("), jika kita ingin menambahkan petik didalam petik itu akan menyebabkan compile-time-error
     *     string text = "This is a "string" in C#."; --Error
     * Untuk menggunakan special character di C# sama seperti di bahasa pemrograman lain yaitu menggunakan escaping characterr (\) backslash
     * sebelum special character disisipkan  kedalam string
     *     string text = "This is a \"string\" in C#.";
     *
     * Verbatim Strings: verbatim string di C# digunakan untuk mengabaikan special character dan line break (\n).
     * verbatim string bisa dibuat dengan keyword @ sebelum petik dua
     * string path = @"\\mypc\shared\project";
     * 
     * Nullable type: nullable data types
     *     string? data = null;
     *     Nullable<int> i = null;
     *
     * ?? Operator: digunakan untuk meng-assign value dari nullable type ke non-nullable type
     *     int? i = null;
     *     int j = i ?? 0;
     * 
     */

}