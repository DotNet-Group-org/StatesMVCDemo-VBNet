Namespace StatesMVCDemo
    Public Class StatesController
        Inherits System.Web.Mvc.Controller

        Dim stateRepository As IRepository

        Public Sub New()
            stateRepository = New Repository
        End Sub

        Public Sub New(ByRef repository As IRepository)
            stateRepository = repository
        End Sub

        '
        ' GET: /States

        Function Index() As ActionResult
            Dim model As List(Of StateNameEntryModel)
            model = stateRepository.GetAllStateNames()

            Return View(model)
        End Function

    End Class
End Namespace