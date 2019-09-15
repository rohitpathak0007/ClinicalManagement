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
            categories: ['Last 30 Days', '2 Months Ago', '3 Months Ago', '4 Months Ago']
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
            name: 'MCTS Records Loaded',
            data: [1.0, 6.9, 9.5,5.5]
        },
            {
            name: 'MCTS Records Processed',
            data: [3.9, 4.2, 5.7,2.3]
        },
            {
                name: 'MCTS Records Approved',
                data: [6.9, 2.2, 3.7,4.7]
            }
        ]
    });
    $('#containerblock').highcharts({
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
            categories: ['Last 30 Days', '2 Months Ago', '3 Months Ago', '4 Months Ago']
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
            name: 'MCTS Records Processed',
            data: [1.0, 6.9, 9.5,5.5]
        },

            {
                name: 'MCTS Records Approved',
                data: [6.9, 2.2, 3.7,4.7]
            }
        ]
    });
});