# CSharp-Basic_To-Advance
C#(CSharp) basic to advance.

Q:What is .Net | DotNet?
A: It is technology or plateform that is used to create multiple type of applications using .Net framework and programming language. DotNet support 90+ programming language but C#, F# J#,C++ and VB language is compatible programming language under .Net.

Type of applications:
1) Desktop Application: C#, Console Application, Windows Form Application, WPF (Windows Presentation Foundation)
2) Web Application: ASP.NET Classic, ASP.NET MVC, ASP.NET Core MVC
3) Mobile Application: MAUI.NET (create IOS and Android Application).
4) Cloud Application: Microsoft Window Azure
5) API Based Application: WEB API, WEB Services, WCF(Windows Communication Foundation)

Q: What is C#?
A: It is an Object Oriented Programming language that is most compatible programming language under DotNet Framework. It provide data security, reuseability of code and easy syntax structure to developer.

Step#01: (Syntax):
Namespace
class Classname{
    public static void main(){

    }
}

Step#02: (Compile):
CMD: csc Filename
C# -> Compiler -> CIL (Common Intermediate Language Code) -> CLR (Common Language Runtime) -> Binary Code -> Operating System

Step#03: (Execute):
CMD: Filename.exe


Q: What is Visual Studio ?
A: It is an IDE tool that provide complete plateform to create project, compile, debug, execute and deploy .NET application.

Q: What are variable, constant and literals?
A: Variable is used to contain the data that can be changed dynamically. Variable represented by datatype and identifier.
var = undefined

Syntax Of Variable
datatype identifier = value;

Type Of variable according to memory allocation:
1) This variable store data under stack memory that will be allocated after compilation.
Syntax:
static datatype variablename = value;

2) Non-Static or instance or dynamic: this variable store data under heap memory that will allocated by object.
datatype vaiablename = value;

public class WarehouseItem 
{
    public string ItemName;        // Non-Static: Each item has its own name
    public static string SiteID;   // Static: All items belong to the same Site
}

Type Of Variable according to the scope:
1) Global Variable: This type of variable declared under class and in case of static it will be called by classname and in case of instance it will be called by object.

class A{
    int a; //non static global
    static int b; // static global variable
}

2) Local Variable: This type of vairable declared under function and it will be called by function();

class A{
    static void fun(){
        int a = 10; // static
    }
    void fun1(){
        int b = 100; //instance or non-static
    }
}