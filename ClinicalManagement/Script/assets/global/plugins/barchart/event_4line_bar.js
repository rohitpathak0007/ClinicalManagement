$(function () {
    $('#container').highcharts({
        chart: {
            type: 'line'
        },
        title: {
            text: ''
        },
        subtitle: {
            text: ''
        },
        xAxis: {
            categories: ['March 2016', 'February 2016', 'January 2016', 'December 2015']
        },
        yAxis: {
            title: {
                text: 'Count'
            }
        },
        plotOptions: {
            line: {
                dataLabels: {
                    enabled: true
                },
                enableMouseTracking: false
            }
        },
        series: [{
            name: 'Median Time Event vs. Data Entry',
            data: [1.0, 6.9, 9.5,5.5]
        },
            {
            name: 'Median Time Approver 1',
            data: [3.9, 4.2, 5.7,2.3]
        },

            {
                name: 'Median Time to Bank',
                data: [1.9, 2.9, 1.7,8.7]
            }
        ]
    });
});