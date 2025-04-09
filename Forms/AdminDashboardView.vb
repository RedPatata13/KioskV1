Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Controls
Imports Autofac
Imports Guna.UI2.WinForms
Imports KioskV0.KioskV0.Services
Imports LiveCharts
Imports LiveCharts.Wpf

Namespace KioskV0.Forms
    Public Class AdminDashboardView
        Public Property RangeOfDateClick As Action
        Private Property _order As List(Of Order)
        Public Property Order As List(Of Order)
            Get
                Return _order
            End Get
            Set(value As List(Of Order))
                _order = value
            End Set
        End Property

        Private Property _totalSales As String
        Public Property TotalSales As String
            Get
                Return _totalSales
            End Get
            Set(value As String)
                _totalSales = value
                TotalSalesLabel.Text = value
            End Set
        End Property
        Private Property _netProfit As String
        Public Property NetProfit As String
            Get
                Return _netProfit
            End Get
            Set(value As String)
                _totalSales = value
                NetProfitLabel.Text = value
            End Set
        End Property
        Private Property _previousSales As String
        Public Property PreviousSales As String
            Get
                Return _previousSales
            End Get
            Set(value As String)
                _previousSales = value
                PreviousSalesLabel.Text = value
            End Set
        End Property
        Private Property _growth As String
        Public Property Growth As String
            Get
                Return _growth
            End Get
            Set(value As String)
                _growth = value
                GrowthLabel.Text = value
            End Set
        End Property
        Private Property _growthPercentage As String
        Public Property GrowthPercentage As String
            Get
                Return _growthPercentage
            End Get
            Set(value As String)
                _growthPercentage = value
                GrowthPercentageLabel.Text = value
            End Set
        End Property
        Private Property _numberOfCustomers As String
        Public Property NumberOfCustomers As String
            Get
                Return _numberOfCustomers
            End Get
            Set(value As String)
                _numberOfCustomers = value
                NumberOfCustomersLabel.Text = value
            End Set
        End Property
        Public Property StartingDateDateTime As DateTime
            Get
                Return DateTime.Parse(StartingDateDateTimePicker.Value).Date
            End Get
            Set(value As DateTime)
                StartingDateDateTimePicker.Value = value
            End Set
        End Property
        Public Property EndDateDateTime As DateTime
            Get
                Return DateTime.Parse(EndDateDateTimePicker.Value).Date
            End Get
            Set(value As DateTime)
                EndDateDateTimePicker.Value = value
            End Set
        End Property
        Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles FilterButton.Click
            RangeOfDateClick?.Invoke()
        End Sub

        Public Sub LoadChart()

            Dim salesValues As New ChartValues(Of Double)
            Dim labels As New List(Of String)

            For Each sale In _order
                salesValues.Add(sale.TotalAmount) ' Add sales amount
                labels.Add(sale.CreatedAt.ToString("MM/dd")) ' Format date as MM/dd
            Next

            ' Set up the chart series
            Dim series As New LineSeries With {
                .Title = "Sales",
                .Values = salesValues,
                .PointGeometry = DefaultGeometries.Circle,
                .PointGeometrySize = 8
            }

            ' Update chart data
            SalesLineGraph.Series = New SeriesCollection From {series}

            ' Update X-axis labels
            SalesLineGraph.AxisX.Clear()
            SalesLineGraph.AxisX.Add(New Axis With {
                .Title = "Date",
                .Labels = labels
            })

            ' Update Y-axis
            SalesLineGraph.AxisY.Clear()
            SalesLineGraph.AxisY.Add(New Axis With {
                .Title = "Sales Amount",
                .LabelFormatter = Function(value) value.ToString("C", New Globalization.CultureInfo("fil-PH"))
            })
        End Sub
    End Class
End Namespace
