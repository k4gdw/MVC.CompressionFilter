Imports System.Runtime.CompilerServices

Module Extensions

	''' <summary>
	''' Determines whether [the specified a string] [is empty or null] .
	''' </summary>
	''' <param name="aString">A string.</param>
	''' <returns>
	''' <c>true</c> if [is empty or null] [the specified a string]; otherwise, <c>false</c>.
	''' </returns>
	''' <remarks>
	''' <para>
	''' I created this extension method so that I could use this functionality in a fluent manner
	''' like so:
	''' <code>
	''' Dim x As String
	''' If x.IsEmptyOrNull Then
	''' 'do stuff
	''' End If
	''' </code>
	''' instead of having to do it like this:
	''' <code>
	''' Dim x as String
	''' If String.IsNullOrEmpty(x) or String.IsNullOrWhiteSpace(x) Then
	''' ' do stuff
	''' End If
	''' </code>
	''' </para>
	''' <para>
	''' Created:  5/23/2012 at 9:10 AM<br />
	''' By:       bryan.johns
	''' </para>
	''' </remarks>
	<Extension()>
	Public Function IsEmptyOrNull(aString As String) As Boolean
		Return String.IsNullOrEmpty(aString) OrElse String.IsNullOrWhiteSpace(aString)
	End Function

End Module
