Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

<MetadataType(GetType(State_Validation))>
Partial Public Class State

    ' Partial class compiled with code produced by VS designer
End Class

<Bind()>
Public Class State_Validation
    Public Property stateID As Integer

    <DisplayName("State Name")>
    <RegularExpression(AlphaRegPattern, ErrorMessage:="Invalid special characters detected.")>
    <Required()>
    <StringLength(50, ErrorMessage:="Must be under 50 characters")>
    Public Property stateName As String

    <DisplayName("State Abbreviation")>
    <RegularExpression(StateRegPattern, ErrorMessage:="Invalid characters detected.")>
    <Required()>
    <StringLength(2, MinimumLength:=2, ErrorMessage:="Abbreviation must be 2 characters")>
    Public Property stateAbbr As String

    <DisplayName("Capital")>
    <DisplayFormat(ConvertEmptyStringToNull:=False)>
    <RegularExpression(ASCIIBasicRegPattern, ErrorMessage:="Invalid special characters detected.")>
    <StringLength(50, ErrorMessage:="Must be under 50 characters")>
    Public Property stateCapital As String

    <DisplayName("Bird")>
    <DisplayFormat(ConvertEmptyStringToNull:=False)>
    <RegularExpression(ASCIIBasicRegPattern, ErrorMessage:="Invalid special characters detected.")>
    <StringLength(50, ErrorMessage:="Must be under 50 characters")>
    Public Property stateBird As String

    <DisplayName("Flower")>
    <DisplayFormat(ConvertEmptyStringToNull:=False)>
    <RegularExpression(ASCIIBasicRegPattern, ErrorMessage:="Invalid special characters detected.")>
    <StringLength(50, ErrorMessage:="Must be under 50 characters")>
    Public Property stateFlower As String

    <DisplayName("Tree")>
    <DisplayFormat(ConvertEmptyStringToNull:=False)>
    <RegularExpression(ASCIIBasicRegPattern, ErrorMessage:="Invalid special characters detected.")>
    <StringLength(50, ErrorMessage:="Must be under 50 characters")>
    Public Property stateTree As String

    <DisplayName("Region")>
    <DisplayFormat(ConvertEmptyStringToNull:=False)>
    <RegularExpression(ASCIIBasicRegPattern, ErrorMessage:="Invalid special characters detected.")>
    <StringLength(50, ErrorMessage:="Must be under 50 characters")>
    Public Property stateRegion As String

    <DisplayName("State Flag")>
    <DisplayFormat(ConvertEmptyStringToNull:=False)>
    <RegularExpression(ASCIIBasicRegPattern, ErrorMessage:="Invalid special characters detected.")>
    <StringLength(50, ErrorMessage:="Must be under 50 characters")>
    Public Property stateImageFlag As String

    <DisplayName("State Seal")>
    <DisplayFormat(ConvertEmptyStringToNull:=False)>
    <RegularExpression(ASCIIBasicRegPattern, ErrorMessage:="Invalid special characters detected.")>
    <StringLength(50, ErrorMessage:="Must be under 50 characters")>
    Public Property stateImageSeal As String
End Class
