@Imports StatesMVCDemo_VBNet
@ModelType StatesMVCDemo_VBNet.StateDetailModel

@Code
    ViewData("Title") = "Details"
End Code

<table class="stateTable">
    <tr class="stateTableRow">
        <td class="stateTableCellName">
            @Html.Partial("StateNameList", Model.stateNames )
        </td>

        <td class="stateTableCellData">
            <table class="stateDetailTable">
               <tr class="stateDetailTableRow">
                    <td class="stateDetailTableCellLabel">&nbsp;</td>
                    <td class="stateDetailTableCellData">&nbsp</td>
                    <td class="stateDetailTableCellEdit">[&nbsp;@Html.ActionLink("Edit", "Edit", "State", New With {.id = Model.stateDetails.stateAbbr}, Nothing)&nbsp;]&nbsp;&nbsp;&nbsp;[&nbsp;@Html.ActionLink("Delete", "Delete", "State", New With {.id = Model.stateDetails.stateAbbr}, Nothing)&nbsp;]</td>
                </tr>
                
                <tr class="stateDetailTableRow">
                    <td colspan="2" class="stateDetailTableCellStateName">
                        @Model.stateDetails.stateName
                    </td>
                    <td class="stateDetailTableCellStateAbbr">
                        @Model.stateDetails.stateAbbr
                    </td>
                </tr>

                <tr class="stateDetailTableRow">
                    <td class="stateDetailTableCellLabel">Capital</td>
                    <td class="stateDetailTableCellData">@Model.stateDetails.stateCapital</td>
                    <td class="stateDetailTableCellFiller">&nbsp;</td>
                </tr>

                <tr class="stateDetailTableRow">
                    <td class="stateDetailTableCellLabel">Bird</td>
                    <td class="stateDetailTableCellData">@Model.stateDetails.stateBird</td>
                    <td class="stateDetailTableCellFiller">&nbsp;</td>
                </tr>


                <tr class="stateDetailTableRow">
                    <td class="stateDetailTableCellLabel">Flower</td>
                    <td class="stateDetailTableCellData">@Model.stateDetails.stateFlower</td>
                    <td class="stateDetailTableCellFiller">&nbsp;</td>
                </tr>

                <tr class="stateDetailTableRow">
                    <td class="stateDetailTableCellLabel">Tree</td>
                    <td class="stateDetailTableCellData">@Model.stateDetails.stateTree</td>
                    <td class="stateDetailTableCellFiller">&nbsp;</td>
                </tr>

                @If Model.stateDetails.stateImageFlag <> "" Then
                    @<tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellImageLabel">State Flag</td>
                        <td class="stateDetailTableCellImage" colspan="2">
                            <img src="@Url.content(Model.stateDetails.stateImageFlag)" alt="State flag" />
                        </td>
                    </tr>
                End If

                @If Model.stateDetails.stateImageSeal <> "" Then
                    @<tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellImageLabel">State Seal</td>
                        <td class="stateDetailTableCellImage" colspan="2">
                            <img src="@Url.Content(Model.stateDetails.stateImageSeal)" alt="State seal" />
                        </td>
                    </tr>
                End If

            </table>
        </td>
    </tr>
</table>

