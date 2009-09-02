﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

// Never used field
#pragma warning disable 0169
// Field will always have default value
#pragma warning disable 0649

using System;

namespace Debugger.Tests.TestPrograms
{
	public class DebugType_Access
	{
		private   int privateField;
		public    int publicField;
		protected int protectedField;
		internal  int internalField;
		static    int staticField;
		
		private   int privateProperty { get { return 0; } }
		public    int publicProperty { get { return 0; } }
		protected int protectedProperty { get { return 0; } }
		internal  int internalProperty { get { return 0; } }
		static    int staticProperty { get { return 0; } }
		
		private   void privateMethod() {}
		public    void publicMethod() {}
		protected void protectedMethod() {}
		internal  void internalMethod() {}
		static    void staticMethod() {}
		
		public static void Main()
		{
			System.Diagnostics.Debugger.Break();
		}
	}
	
	public class Metadata2 {}
	public class Metadata3 {}
	public class Metadata4 {}
	public class Metadata5 {}
	public class Metadata6 {}
	public class Metadata7 {}
}

#if TEST_CODE
namespace Debugger.Tests {
	using Debugger.MetaData;
	
	public partial class DebuggerTests
	{
		[NUnit.Framework.Test]
		public void DebugType_Access()
		{
			StartTest("DebugType_Access.cs");
			
			process.Options.StepOverSingleLineProperties = false;
			process.Options.StepOverFieldAccessProperties = true;
			
			ObjectDump("Members", process.SelectedStackFrame.MethodInfo.DeclaringType.GetMembers(BindingFlags.All));
			ObjectDump("Types", process.SelectedStackFrame.MethodInfo.Module.GetNamesOfDefinedTypes());
			
			EndTest();
		}
	}
}
#endif

#if EXPECTED_OUTPUT
<?xml version="1.0" encoding="utf-8"?>
<DebuggerTests>
  <Test
    name="DebugType_Access.cs">
    <ProcessStarted />
    <ModuleLoaded>mscorlib.dll (No symbols)</ModuleLoaded>
    <ModuleLoaded>DebugType_Access.exe (Has symbols)</ModuleLoaded>
    <DebuggingPaused>Break DebugType_Access.cs:39,4-39,40</DebuggingPaused>
    <Members
      Capacity="64"
      Count="34">
      <Item>
        <FieldInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.privateField"
          IsPrivate="True"
          Module="DebugType_Access.exe"
          Name="privateField"
          Type="System.Int32" />
      </Item>
      <Item>
        <FieldInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.publicField"
          IsPublic="True"
          Module="DebugType_Access.exe"
          Name="publicField"
          Type="System.Int32" />
      </Item>
      <Item>
        <FieldInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.protectedField"
          IsProtected="True"
          Module="DebugType_Access.exe"
          Name="protectedField"
          Type="System.Int32" />
      </Item>
      <Item>
        <FieldInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.internalField"
          IsInternal="True"
          Module="DebugType_Access.exe"
          Name="internalField"
          Type="System.Int32" />
      </Item>
      <Item>
        <FieldInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.staticField"
          IsPrivate="True"
          IsStatic="True"
          Module="DebugType_Access.exe"
          Name="staticField"
          Type="System.Int32" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.get_privateProperty"
          IsPrivate="True"
          IsSpecialName="True"
          Module="DebugType_Access.exe"
          Name="get_privateProperty"
          ReturnType="System.Int32" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.get_publicProperty"
          IsPublic="True"
          IsSpecialName="True"
          Module="DebugType_Access.exe"
          Name="get_publicProperty"
          ReturnType="System.Int32" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.get_protectedProperty"
          IsProtected="True"
          IsSpecialName="True"
          Module="DebugType_Access.exe"
          Name="get_protectedProperty"
          ReturnType="System.Int32" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.get_internalProperty"
          IsInternal="True"
          IsSpecialName="True"
          Module="DebugType_Access.exe"
          Name="get_internalProperty"
          ReturnType="System.Int32" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.get_staticProperty"
          IsPrivate="True"
          IsSpecialName="True"
          IsStatic="True"
          Module="DebugType_Access.exe"
          Name="get_staticProperty"
          ReturnType="System.Int32" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.privateMethod"
          IsPrivate="True"
          Module="DebugType_Access.exe"
          Name="privateMethod" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.publicMethod"
          IsPublic="True"
          Module="DebugType_Access.exe"
          Name="publicMethod" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.protectedMethod"
          IsProtected="True"
          Module="DebugType_Access.exe"
          Name="protectedMethod" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.internalMethod"
          IsInternal="True"
          Module="DebugType_Access.exe"
          Name="internalMethod" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.staticMethod"
          IsPrivate="True"
          IsStatic="True"
          Module="DebugType_Access.exe"
          Name="staticMethod" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.Main"
          IsPublic="True"
          IsStatic="True"
          Module="DebugType_Access.exe"
          Name="Main" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access..ctor"
          IsPublic="True"
          IsSpecialName="True"
          Module="DebugType_Access.exe"
          Name=".ctor"
          StepOver="True" />
      </Item>
      <Item>
        <PropertyInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.privateProperty"
          GetMethod="get_privateProperty"
          IsPrivate="True"
          Module="DebugType_Access.exe"
          Name="privateProperty"
          Type="System.Int32" />
      </Item>
      <Item>
        <PropertyInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.publicProperty"
          GetMethod="get_publicProperty"
          IsPublic="True"
          Module="DebugType_Access.exe"
          Name="publicProperty"
          Type="System.Int32" />
      </Item>
      <Item>
        <PropertyInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.protectedProperty"
          GetMethod="get_protectedProperty"
          IsProtected="True"
          Module="DebugType_Access.exe"
          Name="protectedProperty"
          Type="System.Int32" />
      </Item>
      <Item>
        <PropertyInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.internalProperty"
          GetMethod="get_internalProperty"
          IsInternal="True"
          Module="DebugType_Access.exe"
          Name="internalProperty"
          Type="System.Int32" />
      </Item>
      <Item>
        <PropertyInfo
          DeclaringType="Debugger.Tests.TestPrograms.DebugType_Access"
          FullName="Debugger.Tests.TestPrograms.DebugType_Access.staticProperty"
          GetMethod="get_staticProperty"
          IsPrivate="True"
          IsStatic="True"
          Module="DebugType_Access.exe"
          Name="staticProperty"
          Type="System.Int32" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="System.Object"
          FullName="System.Object..ctor"
          IsPublic="True"
          IsSpecialName="True"
          Module="mscorlib.dll"
          Name=".ctor"
          StepOver="True" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="System.Object"
          FullName="System.Object.ToString"
          IsPublic="True"
          Module="mscorlib.dll"
          Name="ToString"
          ReturnType="System.String"
          StepOver="True" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="System.Object"
          FullName="System.Object.Equals"
          IsPublic="True"
          Module="mscorlib.dll"
          Name="Equals"
          ParameterCount="1"
          ParameterTypes="{System.Object}"
          ReturnType="System.Boolean"
          StepOver="True" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="System.Object"
          FullName="System.Object.Equals"
          IsPublic="True"
          IsStatic="True"
          Module="mscorlib.dll"
          Name="Equals"
          ParameterCount="2"
          ParameterTypes="{System.Object, System.Object}"
          ReturnType="System.Boolean"
          StepOver="True" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="System.Object"
          FullName="System.Object.ReferenceEquals"
          IsPublic="True"
          IsStatic="True"
          Module="mscorlib.dll"
          Name="ReferenceEquals"
          ParameterCount="2"
          ParameterTypes="{System.Object, System.Object}"
          ReturnType="System.Boolean"
          StepOver="True" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="System.Object"
          FullName="System.Object.GetHashCode"
          IsPublic="True"
          Module="mscorlib.dll"
          Name="GetHashCode"
          ReturnType="System.Int32"
          StepOver="True" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="System.Object"
          FullName="System.Object.GetType"
          IsPublic="True"
          Module="mscorlib.dll"
          Name="GetType"
          ReturnType="System.Type"
          StepOver="True" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="System.Object"
          FullName="System.Object.Finalize"
          IsProtected="True"
          Module="mscorlib.dll"
          Name="Finalize"
          StepOver="True" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="System.Object"
          FullName="System.Object.MemberwiseClone"
          IsProtected="True"
          Module="mscorlib.dll"
          Name="MemberwiseClone"
          ReturnType="System.Object"
          StepOver="True" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="System.Object"
          FullName="System.Object.FieldSetter"
          IsPrivate="True"
          Module="mscorlib.dll"
          Name="FieldSetter"
          ParameterCount="3"
          ParameterTypes="{System.String, System.String, System.Object}"
          StepOver="True" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="System.Object"
          FullName="System.Object.FieldGetter"
          IsPrivate="True"
          Module="mscorlib.dll"
          Name="FieldGetter"
          ParameterCount="3"
          ParameterTypes="{System.String, System.String, System.Object}"
          StepOver="True" />
      </Item>
      <Item>
        <MethodInfo
          DeclaringType="System.Object"
          FullName="System.Object.GetFieldInfo"
          IsPrivate="True"
          Module="mscorlib.dll"
          Name="GetFieldInfo"
          ParameterCount="2"
          ParameterTypes="{System.String, System.String}"
          ReturnType="System.Reflection.FieldInfo"
          StepOver="True" />
      </Item>
    </Members>
    <Types
      Capacity="8"
      Count="7">
      <Item>Debugger.Tests.TestPrograms.DebugType_Access</Item>
      <Item>Debugger.Tests.TestPrograms.Metadata2</Item>
      <Item>Debugger.Tests.TestPrograms.Metadata3</Item>
      <Item>Debugger.Tests.TestPrograms.Metadata4</Item>
      <Item>Debugger.Tests.TestPrograms.Metadata5</Item>
      <Item>Debugger.Tests.TestPrograms.Metadata6</Item>
      <Item>Debugger.Tests.TestPrograms.Metadata7</Item>
    </Types>
    <ProcessExited />
  </Test>
</DebuggerTests>
#endif // EXPECTED_OUTPUT