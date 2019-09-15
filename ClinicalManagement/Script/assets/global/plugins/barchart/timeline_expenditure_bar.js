$(document).ready(function() {
    $('#container').highcharts({
        chart: {
            type: 'column'
        },
        title: {
            text: ''
        },
        subtitle: {
            text: ''
        },
        xAxis: {
            categories: [
                'Apr',
                'May',
                'Jun',
                'Jul',
                'Aug',
                'Sep',
                'Oct',

            ],
            crosshair: true
        },
        yAxis: {
            min: 0,
            title: {
                text: 'Amount'
            }
        },
        tooltip: {
            headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
            pointFormat: '<tr><td style="color:{series.color};padding:0">{series.name}: </td>' +
            '<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>',
            footerFormat: '</table>',
            shared: true,
            useHTML: true
        },
        plotOptions: {
            column: {
                pointPadding: 0.2,
                borderWidth: 0
            }
        },
        series: [{
            name: 'Expenditure per Month',
            data: [49.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6,]

        }, {
            name: 'Payments to Date',
            data: [83.6, 78.8, 98.5, 93.4, 106.0, 84.5, 105.0,]

        },
            {
                name: 'Recipients to Date',
                data: [83.6, 78.8, 98.5, 93.4, 106.0, 84.5, 105.0,]

            },
        ]
    });
});