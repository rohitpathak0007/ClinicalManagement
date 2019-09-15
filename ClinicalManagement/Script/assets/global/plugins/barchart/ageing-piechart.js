$(function () {

    $(document).ready(function () {

        // Build the chart
        $('#ageingcont').highcharts({
            chart: {
                plotBackgroundColor: null,
                plotBorderWidth: null,
                plotShadow: false,
                type: 'pie',
                //marginLeft:-230
            },
            title: {
                text: 'Ageing of Payment Processing'
            },
            tooltip: {
                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
            },
            plotOptions: {
                pie: {
                    allowPointSelect: true,
                    cursor: 'pointer',
                    dataLabels: {
                        enabled: false
                    },
                    showInLegend: true


                }

            },

            series: [{
                name: 'Payments',
                colorByPoint: true,
                data: [{
                    name: 'Same day',
                    y:20,
                    sliced: true,
                    selected: true
                }, {
                    name: 'Less than 7 days',
                    y: 30,

                }, {
                    name: 'Less than 30 days',
                    y: 15,
                }, {
                    name: 'More than 30 days',
                    y: 35
                },

                ]
            }]
        });

    });
});