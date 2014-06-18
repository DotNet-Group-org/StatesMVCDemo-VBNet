Namespace StatesMVCDemo
    Public Class StateController
        Inherits System.Web.Mvc.Controller

        Dim stateRepository As IRepository

        Public Sub New()
            stateRepository = New Repository
        End Sub

        Public Sub New(ByRef repository As IRepository)
            stateRepository = repository
        End Sub

        '
        ' GET: /State

        Function Index() As ActionResult
            Return RedirectToAction("Index", "States")
        End Function

        '
        ' GET: /State/Details/5

        Function Details(ByVal id As String) As ActionResult
            Dim model As StateDetailModel
            model = stateRepository.GetStateDetails(id)

            Return View(model)
        End Function

        '
        ' GET: /State/Create

        Function Create() As ActionResult
            Dim model As List(Of StateNameEntryModel)
            Dim entry As New State

            ' can't pass the StateDetailModel object to the view as it then causes
            ' the Create action to not properly propulate the State object.
            '
            ' so instead, passing the stateDetails as the model, and the stateNames via the ViewBag
            model = stateRepository.GetAllStateNames()
            ViewBag.stateNames = model
            Return View(entry)
        End Function

        '
        ' POST: /State/Create

        <HttpPost()> _
        Function Create(ByVal entry As State) As ActionResult

            Try
                ' TODO: Add update logic here
                If ModelState.IsValid Then
                    stateRepository.SaveStateDetails(entry)

                    Return RedirectToAction("Details", "State", New With {.id = entry.stateAbbr})
                Else
                    Dim model As List(Of StateNameEntryModel)
                    model = stateRepository.GetAllStateNames(entry.stateAbbr)

                    ViewBag.stateNames = model
                    Return View(entry)
                End If
            Catch
                Return RedirectToAction("Details", "State", New With {.id = entry.stateAbbr})
            End Try
        End Function
        
        '
        ' GET: /State/Edit/5

        Function Edit(ByVal id As String) As ActionResult
            Dim model As StateDetailModel
            model = stateRepository.GetStateDetails(id, False)

            ' can't pass the StateDetailModel object to the view as it then causes
            ' the Edit action to not properly propulate the State object.
            '
            ' so instead, passing the stateDetails as the model, and the stateNames via the ViewBag

            ViewBag.stateNames = model.stateNames
            Return View(model.stateDetails)
        End Function

        '
        ' POST: /State/Edit/5

        <HttpPost()> _
        Function Edit(ByVal entry As State) As ActionResult

            Try
                ' TODO: Add update logic here
                If ModelState.IsValid Then
                    stateRepository.SaveStateDetails(entry)

                    Return RedirectToAction("Details", "State", New With {.id = entry.stateAbbr})
                Else
                    Dim model As List(Of StateNameEntryModel)
                    model = stateRepository.GetAllStateNames(entry.stateAbbr)

                    ViewBag.stateNames = model
                    Return View(entry)
                End If
            Catch
                Return RedirectToAction("Details", "State", New With {.id = entry.stateAbbr})
            End Try
        End Function

        '
        ' GET: /State/Delete/5

        Function Delete(ByVal id As String) As ActionResult
            stateRepository.DeleteState(id)
            Return RedirectToAction("Index", "States")
        End Function

        '
        ' POST: /State/Delete/5

        <HttpPost()> _
        Function Delete(ByVal id As String, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace