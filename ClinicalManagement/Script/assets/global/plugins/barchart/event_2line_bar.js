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
            name: 'Median Approval Time',
            data: [7.0, 6.9, 9.5, 5.5 ]
        }, {
            name: 'Median Time to Bank',
            data: [3.9, 4.2, 5.7, 1.5]
        }]
    });
    $('#containerevent').highcharts({
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
            name: 'Median Time Approver 1',
            data: [7.0, 6.9, 9.5, 5.5 ]
        }, {
            name: 'Median Time-Event vs Data Entry',
            data: [1.9, 2.2, 8.7, 5.5]
        }
            ,
             {
                name: 'Median Time to Bank',
                data: [5.9, 3.2, 2.7, 9.5]
            }
        ]
    });
});