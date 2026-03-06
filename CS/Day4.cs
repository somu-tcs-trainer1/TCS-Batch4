/*
//DATA TYPES
//1. VALUE TYPES
//2. REFERENCE TYPES
//------------------
//8 - INTEGRAL TYPES

//signed values / types
sbyte sbyte1 = 125; //between -128 and 127 //8-bit 1111 1111
short short1 = 23456; //-32768 and 32767 //16-bit
int int1 = 234567669; // -2**31 to 2**31-1
long long1 = -1235457457547567;

byte byte1 = 255; //0 to 255

Console.WriteLine(sbyte1);
Console.WriteLine(short1);
Console.WriteLine(int1);
Console.WriteLine(long1);
Console.WriteLine(byte1);

//unsigned types
ushort ushort1 = 65456; //0 to 2**16 - 1
uint uint1 = 23445986; //0 to 2**32 - 1 
ulong unlong1 = 9876567788766; //0 to 2**63 - 1

Console.WriteLine(ushort1);
Console.WriteLine(uint1);
Console.WriteLine(unlong1);

//======================================
//DECIMAL / FLOAT TYPES
float f1 = 345.678659999999999f; //32-bit - 7-digit precision
double d1 = 456789.56781235635656745633456788951234567; //64-bit - 14-15 digit precision

Console.WriteLine(f1);
Console.WriteLine(d1);

decimal dec1 = 12345678901234567890123456789m; //128-bit

//CHAR 
char char1 = 'A';
char char2 = '4';
char char3 = '$';
char char4 = ' ';

Console.WriteLine(char1);
Console.WriteLine(char2);
Console.WriteLine(char3);
Console.WriteLine(char4);

//boolean - true or false
bool availableFlag = true;


//REFERENCE TYPES - 
//STRINGS
string str1 = "Hellow, how are you";
String str2 = "Hi there";

Console.WriteLine(str1);
Console.WriteLine(str2);

//OBJECT TYPE
object object1 = 26;
object object2 = "My String";
object object3 = 679975.897766;
object object4 = '#';

Console.WriteLine(object1);
Console.WriteLine(object2);
Console.WriteLine(object3);
Console.WriteLine(object4);


//ARRAYS - one-dim array
int[] ages = {23, 34, 12, 45, 62, 19}; //static array
Console.WriteLine(ages[3]);

int[] arr1 = new int[5];//dynamic
arr1[0] = 34;
arr1[1] = 23;
arr1[2] = 12;
arr1[3] = 61;
arr1[4] = 45;

int[] arr2 = new int[5]{34, 25, 18, 55, 12}; //3rd way of declaring and initializing values

//Array - two-dimension
string[,] strArr = new string[2,3];//dynamic
//first row
strArr[0,0] = "AA"; //FIRST COL
strArr[0,1] = "AB"; //second col
strArr[0,2] = "AC"; // third col

//second row
strArr[1,0] = "BA"; //FIRST COL
strArr[1,1] = "BB"; //second col
strArr[1,2] = "BC"; // third col

Console.WriteLine(strArr[0,1]);

string[,] strArr2 = new string[2,3]{{"aa", "ab", "ac"}, {"ba", "bb", "bc"}}; //static assignment
Console.WriteLine(strArr2[0,1]);


//OPERATORS

using System.IO.Pipelines;

int a = 10;
int b = 20;

//Arithmetic OPs
int result = a +b;
Console.WriteLine(result);
result = a-b;
Console.WriteLine(result);
result = a*b;
Console.WriteLine(result);
result = a/b;
Console.WriteLine(result);
result = a%b;
Console.WriteLine(result);

//Assignement ops
int result2 = a += 10;
Console.WriteLine(result2);
result2 = a -= 10;
Console.WriteLine(result2);
result2 = a *= 10;
Console.WriteLine(result2);
result2 = a /= 10;
Console.WriteLine("The result a /= 10: " +result2);
result2 = a %= 10;
Console.WriteLine("The result a %= 10: " +result2);

//relational ops
==
!=
>
<
>=
<=

using System.ComponentModel;

int x = 20;
int y = 40;

Console.WriteLine(x==y);
Console.WriteLine(x!=y);
Console.WriteLine(x>y);
Console.WriteLine(x<y);
Console.WriteLine(x>=y);
Console.WriteLine(x<=y);


//Logical Ops
// && - AddingNewEventHandler
// || - or
// ! - not

bool yes = true, no = false;
if( yes && no)
{
 Console.WriteLine("yes and no are true");   
}

if( yes || no)
{
 Console.WriteLine("yes or no are true");   
}

if( !yes)
{
 Console.WriteLine("yes is not true");   
}

if( !no)
{
 Console.WriteLine("no is not true");   
}


//BIT-WISE OPERTORS
int val1 = 6; //0110 = 0011
int val2 = 4; //0100

//Console.WriteLine(val1 & val2); //AND
//Console.WriteLine(val1 | val2); //OR
Console.WriteLine(~val1); //NOT
Console.WriteLine(val1 ^ val2); //XOR
Console.WriteLine(val1 >> 1); //right shift by 1 bit
Console.WriteLine(val1 << 1); //left shift by 1 bit

// TERNARY OPERATOR
int first = 40;
int second = 20;

string result = (first > second) ? "first" : "second";
Console.WriteLine(result +" is greater among the first and second int vars");


//=================================================================================

//CONDITIONAL STATMENTS - IF

 //Simple If
 int hour = 11;
 if(hour < 12){
     Console.WriteLine("Good Morning");
 }

 //If else
 if(hour < 12){
     Console.WriteLine("Good Morning");
 } else{
     Console.WriteLine("Good Day");
 }

 //If else if, else
 int a = 10;
 int b = 20;
 int c = 30;

 if(a>b && a>c){
     Console.WriteLine("a is greatest");
 }else if(b>c){
     Console.WriteLine("b is greatest");
 }else{
     Console.WriteLine("c is greatest");
 }


 //SWITCH CASE
 int day = 7;

 switch(day){
     case 1:
         Console.WriteLine("Monday");
         break;
     case 2:
         Console.WriteLine("Tuesday");
         break;
     case 3:
         Console.WriteLine("Wednesday");
         break;
     case 4:
         Console.WriteLine("Thursday");
         break;
     case 5:
         Console.WriteLine("Friday");
         break;
     case 6:
         Console.WriteLine("Saturday");
         break;
     case 7:
         Console.WriteLine("Sunday");
         break;
     default:
         Console.WriteLine("Plese give day value between 1 and 7");       
         break; 
 }


 //Nested If condition
int marks = 85;

if (marks > 60)
{
    Console.WriteLine("First Class");
    if(marks >= 80)
    {
        Console.WriteLine("Congrats, you got a distinction");
    }
}
*/

// ITERATIVE STATEMENTS / LOOPS
// 1. initialization - initial value set
// 2. condition 
// 3. limit is set

//  WHILE LOOP
 string greet = "Good Morning";
 int count = 1;
 while(count <= 10){
     Console.WriteLine(greet);
     count++;
 }
 Console.WriteLine("Count value after while loop execution: "+count);

 while(count >=1){
     Console.WriteLine(count);
     count--;
 }
 Console.WriteLine("Count value after while loop execution (decrement): "+count);

//FOR LOOP
string greeting1 = "Hello";
 for(int cnt=1 ; cnt <=10 ; cnt++){
     Console.WriteLine(greeting1);    
 }

// object a = 25, b = "hello";

 count = 1;
 string greeting = "Hello";
 for( ; count <=10 ; count++){
     Console.WriteLine(greeting);    
 }
 Console.WriteLine("Count value after for loop execution: "+count);

 for( ; count >=1 ; count--){
     Console.WriteLine(greeting);    
 }
 Console.WriteLine("Count value after for loop execution: "+count);
 
 //var varVariable = 20;