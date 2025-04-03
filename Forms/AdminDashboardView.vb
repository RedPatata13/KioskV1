Imports Guna.UI2.WinForms
Imports LiveCharts
Imports LiveCharts.Wpf

Namespace KioskV0.Forms
    Public Class AdminDashboardView
        Public Property TestButtonClick As Action
        Private salesData As List(Of SalesData) 'test
        Private Sub AdminDashboardView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Load sales data
            LoadSalesData()

            ' Attach event to button click
            AddHandler FilterButton.Click, AddressOf UpdateChart

            ' Load initial chart data
            UpdateChart(Nothing, Nothing)
        End Sub
        Private Sub LoadSalesData()
            ' Simulated sales data
            salesData = New List(Of SalesData) From {
            New SalesData(New Date(2025, 3, 1), 500),
            New SalesData(New Date(2025, 3, 5), 750),
            New SalesData(New Date(2025, 3, 10), 900),
            New SalesData(New Date(2025, 3, 15), 650),
            New SalesData(New Date(2025, 3, 20), 1200),
            New SalesData(New Date(2025, 3, 25), 950),
            New SalesData(New Date(2025, 3, 30), 1300)
        }
        End Sub
        Private Sub UpdateChart(sender As Object, e As EventArgs)
            Dim startDate As DateTime = StartingDateDateTimePicker.Value
            Dim endDate As DateTime = EndDateDateTimePicker.Value

            ' Filter sales data based on selected date range
            Dim filteredData = salesData.
            Where(Function(s) s._Date >= startDate AndAlso s._Date <= endDate).
            OrderBy(Function(s) s._Date).
            Select(Function(s) New ChartValues(Of Double)({s.Amount})).
            ToList()

            ' Extract dates for X-axis labels
            Dim dateLabels = salesData.
            Where(Function(s) s._Date >= startDate AndAlso s._Date <= endDate).
            OrderBy(Function(s) s._Date).
            Select(Function(s) s._Date.ToString("MMM dd")).
            ToArray()

            ' Update chart series
            SalesLineGraph.Series = New SeriesCollection From {
            New LineSeries With {
                .Title = "Sales",
                .Values = New ChartValues(Of Double)(salesData.
                    Where(Function(s) s._Date >= startDate AndAlso s._Date <= endDate).
                    Select(Function(s) s.Amount)
                ),
                .PointGeometrySize = 10
            }
        }

            ' Set X-axis labels
            SalesLineGraph.AxisX.Clear()
            SalesLineGraph.AxisX.Add(New Axis With {
            .Title = "Date",
            .Labels = dateLabels.ToList()
        })

            ' Set Y-axis title
            SalesLineGraph.AxisY.Clear()
            SalesLineGraph.AxisY.Add(New Axis With {
            .Title = "Sales Amount"
        })
        End Sub

        Private Sub StartingDateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles StartingDateDateTimePicker.ValueChanged

        End Sub

        Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles FilterButton.Click

        End Sub
    End Class
    ' Sales Data Class
    Public Class SalesData
        Public Property _Date As DateTime
        Public Property Amount As Double

        Public Sub New(dateVal As DateTime, amountVal As Double)
            _Date = dateVal
            Amount = amountVal
        End Sub
    End Class

End Namespace
