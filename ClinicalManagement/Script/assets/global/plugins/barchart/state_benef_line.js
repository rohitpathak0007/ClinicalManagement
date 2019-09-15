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
                    enabled: false
                },
                enableMouseTracking: false
            }
        },
        series: [{
            name: 'ASHA',
            data: [1.0, 6.9, 9.5,5.5]
        },
            {
            name: 'MOTHER',
            data: [3.9, 4.2, 5.7,2.3]
        },
            {
                name: 'ANM',
                data: [6.9, 2.2, 3.7,4.7]
            }
        ]
    });
    $('#container2').highcharts({
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
            name: 'Institutional Delivery Urban',
            data: [1.0, 6.9, 9.5,5.5]
        },
            {
                name: 'Institutional Delivery Rural',
                data: [9.9, 4.2, 2.7,2.3]
            },
            {
                name: 'Home Deliveries',
                data: [1.9, 10.2, 5.7,4.7]
            }
        ]
    });
});