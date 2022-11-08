# How to apply the embedded custom font in Xamarin.Forms Chart (SfChart)

Each element of [Xamarin.Forms Charts](https://www.syncfusion.com/xamarin-ui-controls/xamarin-charts) can be customized with desired custom font using its in-built support. It also supports to have embedded font family from Xamarin.Forms version 4.6 as specified in [this article](https://devblogs.microsoft.com/xamarin/embedded-fonts-xamarin-forms/).

Here, axis labels are displayed by using the applied embedded custom font of nunito-bold.ttf.

```
[assembly: ExportFont("nunito-bold.ttf", Alias = "Nunito")]
 
namespace Chart_GettingStarted
{
 public partial class MainPage : ContentPage
 {
  public MainPage()
  {
   InitializeComponent();
  }
 }
}
```

```
<chart:SfChart x:Name="Chart" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand">
	<chart:SfChart.BindingContext>
        <local:ViewModel/>
    </chart:SfChart.BindingContext>
 
    <chart:SfChart.PrimaryAxis>
        <chart:CategoryAxis>
            <chart:CategoryAxis.LabelStyle>
                <chart:ChartAxisLabelStyle FontFamily="Nunito" FontSize="13" />
            </chart:CategoryAxis.LabelStyle>
        </chart:CategoryAxis>
    </chart:SfChart.PrimaryAxis>
 
    <chart:SfChart.SecondaryAxis>
        <chart:NumericalAxis>
            <chart:NumericalAxis.LabelStyle>
                <chart:ChartAxisLabelStyle FontFamily="Nunito" FontSize="12"/>
            </chart:NumericalAxis.LabelStyle>
        </chart:NumericalAxis>
    </chart:SfChart.SecondaryAxis>
    <chart:ColumnSeries ItemsSource="{Binding Data}"  XBindingPath="Name" YBindingPath="Height" />
</chart:SfChart>
```

## Output:

![](https://github.com/SyncfusionExamples/How-to-apply-the-embedded-custom-font-in-Xamarin.Forms-Charts/blob/main/Applied-Embedded-Font-on-Axis-Labels.png)

KB article - [How to apply the embedded custom font in Xamarin.Forms Charts](https://www.syncfusion.com/kb/12516/how-to-apply-the-embedded-custom-font-in-xamarin-forms-charts)

## See also

[How to apply custom fonts in Xamarin.Forms Chart](https://www.syncfusion.com/kb/9388/how-to-apply-custom-fonts-in-xamarin-forms-chart)

[How to apply gradient color to Xamarin.Forms Chart segment](https://help.syncfusion.com/xamarin/charts/appearance#gradient-colors)

[How to apply the palette color to Xamarin.Forms Chart](https://help.syncfusion.com/xamarin/charts/appearance#apply-palette-for-chart)
