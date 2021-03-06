========================================================================
    LIBRARY APPLICATION : CSRegFreeCOMServer Project Overview
========================================================================

/////////////////////////////////////////////////////////////////////////////
Summary:

The CSRegFreeCOMServer sample demonstrates a .NET Framework-based component 
which is ready for registration-free activation. 

Registration-free COM is a mechanism available on the Microsoft Windows XP 
(SP2 for .NET Framework-based components), Microsoft Windows Server 2003 and 
newer platforms. As the name suggests, the mechanism enables easy (e.g. 
XCOPY) deployment of COM components to a machine without the need to register 
them.

CSRegFreeCOMServer exposes the following component:

  Program ID: CSRegFreeCOMServer.SimpleObject
  CLSID_SimpleObject: 2384B3E7-4FFD-460d-A5B9-284182707922
  IID_ISimpleObject: 95A215C3-FC49-4f4e-9647-638521470D42
  DIID_ISimpleObjectEvents: 94BAC1E3-1172-41ee-BB83-AE451C8F3C12
  LIBID_CSRegFreeCOMServer: AD958DD7-9EA4-4123-B723-89F078FCC230

  Properties:
    // With both get and set accessor methods
    float FloatProperty

  Methods:
    // HelloWorld returns a string "HelloWorld"
    string HelloWorld();
    // GetProcessThreadID outputs the running process ID and thread ID
    void GetProcessThreadID(out uint processId, out uint threadId);

  Events:
    // FloatPropertyChanging is fired before new value is set to the 
    // FloatProperty property. The Cancel parameter allows the client to 
    // cancel the change of FloatProperty.
    void FloatPropertyChanging(float NewValue, ref bool Cancel);

NOTE: The GUIDs used in this sample are generated by guidgen.exe (Visual 
Studio / Tools / Create GUID). When you write your own COM objects, you need 
to generate and use new GUIDs.


/////////////////////////////////////////////////////////////////////////////
Sample Relation:
(Relation of the current sample and other samples in 
Microsoft All-In-One Code Framework http://cfx.codeplex.com)

CppRegFreeCOMClient -> CSRegFreeCOMServer
CppRegFreeCOMClient registration-free activates the .NET Framework-based 
component CSRegFreeCOMServer.


/////////////////////////////////////////////////////////////////////////////
Creation:

A. Creating the project

Step1. Create a Visual C# / Class Library project named CSRegFreeCOMServer in 
Visual Studio 2008.

Step2. In order to make the .NET assembly COM-visible, first, open the 
property of the project. Click the Assembly Information button in the page, 
Application, and select the "Make Assembly COM-Visible" box. This corresponds 
to the assembly attribute ComVisible in AssemblyInfo.cs:

	[assembly: ComVisible(true)]

The GUID value in the dialog is the libid of the component:

	[assembly: Guid("f0998d9a-0e79-4f67-b944-9e837f479587")]

So that a type library will be generated and registered at build time, set 
the project's Register for COM Interop setting to true in the Build page of 
Project Properties.

B. Adding a component

Step1. Define a "public" COM-visible interface ISimpleObject to describe 
the COM interface of the coclass. Specify its GUID, aka IID, using 
GuidAttribute: 

	[Guid("95A215C3-FC49-4f4e-9647-638521470D42")]

In this way, IID of the COM object is a fixed value. By default, the 
interfaces used by a .NET Class are transformed to dual interfaces 
[InterfaceType(ComInterfaceType.InterfaceIsDual)] in the IDL. This allows the
client to get the best of both early binding and late binding. Other options  
are [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)] and 
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)].

Step2. Inside the interface ISimpleObject, define the prototypes of the \
properties and methods to be exported. The terms marked as 
[ComVisible(false)] are not exported.

Step3. Define a "public" COM-visible interface ISimpleObjectEvents to 
describe the events the coclass can sink. Specify its GUID, aka the Events 
Id, using GuidAttribute:

	[Guid("94BAC1E3-1172-41ee-BB83-AE451C8F3C12")]
	
Decorate the interface as an IDispatch interface:

	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

Step4. Inside the interface ISimpleObjectEvents, define the prototype of 
the events to be exported.

Step5. Define a "public" COM-visible class SimpleObject that implements 
the interface ISimpleObject. Attach the attribute 
[ClassInterface(ClassInterfaceType.None)] to it, which tells the type-library 
generation tools that we do not require a Class Interface. This ensures that 
the ISimpleObject interface is the default interface. In addition, specify 
the GUID of the class, aka CLSID, using the Guid attribute:

	[Guid("2384B3E7-4FFD-460d-A5B9-284182707922")]

In this way, CLSID of the COM object is a fixed value. Last, decorate the 
class with a ComSourceInterface attribute:

	[ComSourceInterfaces(typeof(ICSExplicitInterfaceObjectEvents))]

ComSourceInterfaces identifies a list of interfaces that are exposed as	COM 
event sources for the attributed class.

Step6. Make sure that the constructor of the class SimpleObject is not 
private (we can either add a public constructor or use the default one), so 
that the COM object is creatable from the COM aware clients.

Step7. Inside SimpleObject, implement the interface ISimpleObject by 
writing the body of the property FloatProperty and the methods HelloWorld,  
GetProcessThreadID.

C. Making the assembly ready for registration-free activation

You need to embed a manifest file into the assembly as a Win32 resource to 
make it ready for registration-free activation.

Step1. Add a CSRegFreeCOMServer.manifest file to the project with this 
content:

	<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
	<assembly xmlns="urn:schemas-microsoft-com:asm.v1" 
	  manifestVersion="1.0">
	<assemblyIdentity
		  type="win32"
				name="CSRegFreeCOMServer"
				version="1.0.0.0" />
	<clrClass
				clsid="{2384B3E7-4FFD-460d-A5B9-284182707922}"
				progid="CSRegFreeCOMServer.SimpleObject"
				threadingModel="Both"
				name="CSRegFreeCOMServer.SimpleObject" >
	</clrClass>
	</assembly>

clsid="{2384B3E7-4FFD-460d-A5B9-284182707922}" is the CLSID of the COM class 
defined in SimpleObject.cs, and progid="CSRegFreeCOMServer.SimpleObject" 
is its ProgID.

Step2. In the project's folder create a resource-definition script file (a 
text file) and call it CSRegFreeCOMServer.rc. Paste the following into the 
file:

	#define RT_MANIFEST 24
	1 RT_MANIFEST CSRegFreeCOMServer.manifest

Step3. Open Project Properties, and turn to the Build Events page. In 
Pre-build event command line, enter this command:

	@echo.
	IF EXIST "$(DevEnvDir)..\..\..\Microsoft SDKs\Windows\v6.0A\bin\rc.exe" 
	("$(DevEnvDir)..\..\..\Microsoft SDKs\Windows\v6.0A\bin\rc.exe" /r 
	"$(ProjectDir)CSRegFreeCOMServer.rc") 
	ELSE (IF EXIST "$(DevEnvDir)..\..\SDK\v2.0\Bin\rc.exe" 
	("$(DevEnvDir)..\..\SDK\v2.0\Bin\rc.exe"/r "$(ProjectDir)CSRegFreeCOMServer.rc") 
	ELSE (IF EXIST "$(DevEnvDir)..\Tools\Bin\rc.exe" 
	("$(DevEnvDir)..\Tools\Bin\rc.exe"/r "$(ProjectDir)CSRegFreeCOMServer.rc") 
	ELSE (IF EXIST "$(DevEnvDir)..\..\VC\Bin\rc.exe" 
	("$(DevEnvDir)..\..\VC\Bin\rc.exe"/r "$(ProjectDir)CSRegFreeCOMServer.rc") 
	ELSE (@Echo Unable to find rc.exe, using default manifest instead))))
	@echo.

The command searches for the Resource Compiler (rc.exe), and use the tool to 
compile the resource definition file and any resource files (binary files 
such as icon, bitmap, and cursor files) into a binary resource (.RES) file: 
CSRegFreeCOMServer.RES.

Step4. Turn to the Application page of Project Properties. In the section 
"Specify how application resources will be managed", select "Resource File", 
and enter the full path of CSActiveX.RES that is generated in step 3.

Step5. (Optional) If you perfer a relative path to the full path of 
CSRegFreeCOMServer.RES, you need to modify the project file 
(CSRegFreeCOMServer.csproj). The "Resource File" value corresponds to the XML 
element:

	<Win32Resource>CSRegFreeCOMServer.res</Win32Resource>


/////////////////////////////////////////////////////////////////////////////
References:

Registration-Free Activation of .NET-Based Components: A Walkthrough
http://msdn.microsoft.com/en-us/library/ms973915.aspx


/////////////////////////////////////////////////////////////////////////////