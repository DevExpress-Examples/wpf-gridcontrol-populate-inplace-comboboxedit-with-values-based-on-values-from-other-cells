﻿' Developer Express Code Central Example:
' How to use a combo box whose choices are different for each cell in the grid
' 
' There are two ways to accomplish this task: via filter criteria and by using a
' multibinding approach. Let me explain theses approaches in detail.
' 
' 1) Filter
' criteria
' The main idea is to dynamically construct a filter by using the
' selected value of the first column in the grid. So, items in the ComboBox editor
' will be filtered automatically according to the filter's value. In this case, it
' is necessary to create a converter (which implements the IValueConverter
' interface) in the code-behind file. 2) Multibinding approach.
' You can also
' resolve this problem by using the multibinding approach. Specify multiple
' bindings in a MultiBinding object and create a converter (which implements the
' IMultiValueConverter interface) to produce a final value for the binding target
' property based on values of those bindings.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2163

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3074
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My.Resources


	''' <summary>
	'''   A strongly-typed resource class, for looking up localized strings, etc.
	''' </summary>
	' This class was auto-generated by the StronglyTypedResourceBuilder
	' class via a tool like ResGen or Visual Studio.
	' To add or remove a member, edit your .ResX file then rerun ResGen
	' with the /str option, or rebuild your VS project.
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")>
	<System.Diagnostics.DebuggerNonUserCodeAttribute()>
	<System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
	Global.Microsoft.VisualBasic.HideModuleNameAttribute()>
	Friend Module Resources

		Private resourceMan As System.Resources.ResourceManager

		Private resourceCulture As System.Globalization.CultureInfo

'		internal Resources()
'		{
'		}

		''' <summary>
		'''   Returns the cached ResourceManager instance used by this class.
		''' </summary>
		<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager() As System.Resources.ResourceManager
			Get
				If (resourceMan Is Nothing) Then
					Dim temp As New System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
					resourceMan = temp
				End If
				Return resourceMan
			End Get
		End Property

		''' <summary>
		'''   Overrides the current thread's CurrentUICulture property for all
		'''   resource lookups using this strongly typed resource class.
		''' </summary>
		<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
		Friend Property Culture() As System.Globalization.CultureInfo
			Get
				Return resourceCulture
			End Get
			Set(ByVal value As System.Globalization.CultureInfo)
				resourceCulture = value
			End Set
		End Property
	End Module
End Namespace