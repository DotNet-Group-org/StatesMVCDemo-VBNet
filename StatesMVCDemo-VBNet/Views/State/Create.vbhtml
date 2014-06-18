@Imports StatesMVCDemo_VBNet
@ModelType StatesMVCDemo_VBNet.State


@Code
    ViewData("Title") = "Create"
End Code

<table class="stateTable">
    <tr class="stateTableRow">
        <td class="stateTableCellName">
            @Html.Partial("StateNameList", ViewBag.stateNames)
        </td>

        <td class="stateTableCellData">

            @Html.ValidationSummary("Please correct the errors and try again.")

            @Code 
                Html.BeginForm("Create", "State", FormMethod.Post, Nothing)
            End Code

            @Html.Partial("InputForm", Model)

            @Code
                Html.EndForm()
            End code
        </td>
    </tr>
</table>

