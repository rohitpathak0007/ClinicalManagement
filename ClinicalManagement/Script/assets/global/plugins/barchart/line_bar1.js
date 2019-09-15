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
            name: 'Total User Count',
            data: [7.0, 6.9, 9.5]
        }, {
            name: 'User Accessing',
            data: [3.9, 4.2, 5.7]
        }]
    });
    //$('#excise').highcharts({
    //    chart: {
    //        type: 'line'
    //    },
    //    title: {
    //        text: 'Consolidated flash figure Report for the period from'
    //    },
    //    subtitle: {
    //        text: ' 01/12/2015 To 31/12/2015'
    //    },
    //    xAxis: {
    //        categories: ['Receipt', 'Refund', 'Net', ]
    //    },
    //    yAxis: {
    //        title: {
    //            text: 'Count'
    //        }
    //    },
    //    plotOptions: {
    //        line: {
    //            dataLabels: {
    //                enabled: true
    //            },
    //            enableMouseTracking: false
    //        }
    //    },
    //    series: [{
    //        name: 'Service Tax (0044)',
    //        data: [15535.92, 628.82, 14907.10]
    //    }, {
    //        name: 'Central Excise (0038)',
    //        data: [27553.09, 2891.42, 24661.68]
    //    },
    //        {
    //            name: 'Customs (0037)',
    //            data: [21832.40, 2593.43, 19238.98]
    //        }
    //    ]
    //});
});
