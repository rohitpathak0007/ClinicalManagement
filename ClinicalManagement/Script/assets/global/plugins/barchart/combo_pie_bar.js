$(function () {
    $('#container').highcharts({
        title: {
            text: ''
        },
        xAxis: {
            categories: ['April', 'May', 'June', 'July', 'August', 'September', 'October']
        },
        labels: {
            items: [{
                html: '',
                style: {
                    left: '50px',
                    top: '18px',
                    color: (Highcharts.theme && Highcharts.theme.textColor) || 'black'
                }
            }]
        },
        series: [{
            type: 'column',
            name: 'Expenditure per Month',
            data: [3, 2, 1, 3, 4]
        }, {
            type: 'column',
            name: 'Payments to Date',
            data: [2, 3, 5, 7, 6]
        }, {
            type: 'column',
            name: 'Recipients to Date',
            data: [3, 2.67, 3, 6.33, 3.33],
            marker: {
                lineWidth: 2,
                lineColor: Highcharts.getOptions().colors[3],
                fillColor: 'white'
            }
        }, {
            type: 'pie',
            name: 'Total Value',
            data: [{
                name: 'January',
                y: 13,
                color: Highcharts.getOptions().colors[0] // Jane's color
            }, {
                name: 'February',
                y: 23,
                color: Highcharts.getOptions().colors[1] // John's color
            }, {
                name: 'October',
                y: 19,
                color: Highcharts.getOptions().colors[2] // Joe's color
            }],
            center: [100, 80],
            size: 100,
            showInLegend: false,
            dataLabels: {
                enabled: false
            }
        }]
    });
});