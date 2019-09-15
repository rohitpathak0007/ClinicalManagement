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
                'DEO',
                'Approver',
                'ASHA',

            ],
            crosshair: true
        },
        yAxis: {
            min: 0,
            title: {
                text: 'Count of User'
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
            name: 'Web Browser',
            data: [49.9, 71.5, 106.4, ]

        }, {
            name: 'Mobile App',
            data: [83.6, 78.8, 98.5,]

        },
        ]
    });
});