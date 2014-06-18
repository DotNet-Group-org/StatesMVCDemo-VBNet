Module RegularExpressionPatterns

    Public Const StateRegPattern = "^[A-Z]{2}$"

    ' the following patterns are used to help prevent the web page blowing up with an
    ' "A potentially dangerous Request.Form value was detected from the client" error
    '
    ' alpha characters only
    Public Const AlphaRegPattern = "^[A-Za-z]*$"

    ' numberic only
    Public Const NumericRegPattern = "^[0-9]*$"

    ' minimal allowable characters - alpha and numeric and space only
    Public Const ASCIIMinRegPattern = "^[A-Za-z0-9 ]*$"

    ' slightly larger character set - alpha, numeric, space, apostrophe, hypen, period, comma, pound sign, slash, parentheses, and the ampersand sign.
    Public Const ASCIIBasicRegPattern = "^[A-Za-z0-9\. '/(/)/,#\&\-]*$"

    ' multi-line version of ASCIIBasicRegPattern with the addition of the colon, asterisk and at sign
    Public Const ASCIIMultiBasicRegPattern = "^[A-Za-z0-9\s\. \:\*\@'/,#\&\-]*$"
End Module
