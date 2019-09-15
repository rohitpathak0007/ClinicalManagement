var TableAdvanced = function () {

 var initTable3 = function (DetailRowNeeded,varTableID,EnableCustomButton) {
     var table = $('#'+varTableID);

     /* Formatting function for row details */
     function fnFormatDetails(oTable, nTr) {
         var aData = oTable.fnGetData(nTr);
         var ihasDangerClass=nTr.className.indexOf('danger');
         var showDeactivetedDetails=false;


         var sOut = '<table class="fr">';
         if(ihasDangerClass !=undefined && ihasDangerClass>-1)
         {
          sOut += '<tr><td ><a href="state_config.html"><i class="fa fa-edit"></i>State Maping</a></td><td ><a href="#"><i class="fa fa-edit"></i> Edit</a></td><td><a href="#" class="text-success"><i class="fa fa-plus-square"></i> Activate</a></td></tr>';
         }
         else
         {   sOut += '<tr><td ><a href="state_config.html"><i class="fa fa-edit"></i> State Maping</a></td><td ><a href="#"><i class="fa fa-edit"></i> Edit</a></td><td><a class="text-danger" data-toggle="modal" data-target="#static" ><i class="fa fa-plus-square"></i> Deactivate</a></td></tr>';
         }
         //sOut += '<tr><td></td><td></td></tr>';
         //sOut += '<tr><td></td><td></td></tr>';
         sOut += '</table>';

         return sOut;
     }

     function fnCustomFormatDetails(oTable, nTr) {
		 var aData = oTable.fnGetData(nTr);
         var sOut = '<table style="float:right;">';
         sOut += '<tr><td><a href="extension_request_approve.html" class="text-success"><i class="fa fa-edit"></i> Approve</a></td><td><a href="#" class="text-danger"><i class="fa fa-minus-square"></i> Reject</a></td></tr>';
         //sOut += '<tr><td></td><td></td></tr>';
         //sOut += '<tr><td></td><td></td></tr>';
         sOut += '</table>';

         return sOut;
     }

     /*
      * Insert a 'details' column to the table
      */
     if (DetailRowNeeded == true) {
     var nCloneTh = document.createElement('th');
     nCloneTh.className = "table-checkbox";

     var nCloneTd = document.createElement('td');
     nCloneTd.innerHTML = '<span class="row-details row-details-close"></span>';

     table.find('thead tr').each(function () {
         this.insertBefore(nCloneTh, this.childNodes[0]);
     });

     table.find('tbody tr').each(function () {
         this.insertBefore(nCloneTd.cloneNode(true), this.childNodes[0]);
     });
        }
        /*
         * Initialize DataTables, with no sorting on the 'details' column
         */

        var oTable = table.dataTable({

            // Internationalisation. For more info refer to http://datatables.net/manual/i18n
            "language": {
                "aria": {
                    "sortAscending": ": activate to sort column ascending",
                    "sortDescending": ": activate to sort column descending"
                },
                "emptyTable": "No data available in table",
                "info": "Showing _START_ to _END_ of _TOTAL_ entries",
                "infoEmpty": "No entries found",
                "infoFiltered": "(filtered from _MAX_ total entries)",
                "lengthMenu": "Show _MENU_ entries",
                "Search": "Search:",
                "zeroRecords": "No matching records found"
            },
            "columnDefs": [{
                "orderable": false,
                "targets": [0]
            }],
            "order": [
                [1, 'asc']
            ],
            "lengthMenu": [
                [5, 15, 20],
                [5, 15, 20] // change per page values here
            ],
            // set the initial value
            "pageLength": 10,
        });
        var tableWrapper = $('#'+varTableID+'_wrapper'); // datatable creates the table wrapper by adding with id {your_table_jd}_wrapper

        tableWrapper.find('.dataTables_length bs-select').select2(); // initialize select2 dropdown

        /* Add event listener for opening and closing details
         * Note that the indicator for showing which row is open is not controlled by DataTables,
         * rather it is done here
         */
        table.on('click', ' tbody td .row-details', function () {
            var nTr = $(this).parents('tr')[0];
            if (oTable.fnIsOpen(nTr)) {
                /* This row is already open - close it */
                $(this).addClass("row-details-close").removeClass("row-details-open");
                oTable.fnClose(nTr);
            } else if(EnableCustomButton==true){
                /* Open this row */
                $(this).addClass("row-details-open").removeClass("row-details-close");
                oTable.fnOpen(nTr, fnCustomFormatDetails(oTable, nTr), 'details');
            }
            else {
                $(this).addClass("row-details-open").removeClass("row-details-close");
                oTable.fnOpen(nTr, fnFormatDetails(oTable, nTr), 'details');
            }
        });
    };
	
	 var initTableWithoutConfig = function (DetailRowNeeded,varTableID,EnableCustomButton) {
     var table = $('#'+varTableID);

     /* Formatting function for row details */
     function fnFormatDetails(oTable, nTr) {
         var aData = oTable.fnGetData(nTr);
         var ihasDangerClass=nTr.className.indexOf('danger');
         var showDeactivetedDetails=false;


         var sOut = '<table class="fr">';
         if(ihasDangerClass !=undefined && ihasDangerClass>-1)
         {
          sOut += '<tr><td ><a href="#"><i class="fa fa-edit"></i> Edit</a></td><td><a href="#" class="text-success"><i class="fa fa-plus-square"></i> Activate</a></td></tr>';
         }
         else
         {   sOut += '<tr><td ><a href="#"><i class="fa fa-edit"></i> Edit</a></td><td><a class="text-danger" data-toggle="modal" data-target="#static" ><i class="fa fa-plus-square"></i> Deactivate</a></td></tr>';
         }
         //sOut += '<tr><td></td><td></td></tr>';
         //sOut += '<tr><td></td><td></td></tr>';
         sOut += '</table>';

         return sOut;
     }

     function fnCustomFormatDetails(oTable, nTr) {
		 var aData = oTable.fnGetData(nTr);
         var sOut = '<table style="float:right;">';
         sOut += '<tr><td><a href="extension_request_approve.html" class="text-success"><i class="fa fa-edit"></i> Approve</a></td><td><a href="#" class="text-danger"><i class="fa fa-minus-square"></i> Reject</a></td></tr>';
         //sOut += '<tr><td></td><td></td></tr>';
         //sOut += '<tr><td></td><td></td></tr>';
         sOut += '</table>';

         return sOut;
     }

     /*
      * Insert a 'details' column to the table
      */
     if (DetailRowNeeded == true) {
     var nCloneTh = document.createElement('th');
     nCloneTh.className = "table-checkbox";

     var nCloneTd = document.createElement('td');
     nCloneTd.innerHTML = '<span class="row-details row-details-close"></span>';

     table.find('thead tr').each(function () {
         this.insertBefore(nCloneTh, this.childNodes[0]);
     });

     table.find('tbody tr').each(function () {
         this.insertBefore(nCloneTd.cloneNode(true), this.childNodes[0]);
     });
        }
        /*
         * Initialize DataTables, with no sorting on the 'details' column
         */
        var oTable = table.dataTable({

            // Internationalisation. For more info refer to http://datatables.net/manual/i18n
            "language": {
                "aria": {
                    "sortAscending": ": activate to sort column ascending",
                    "sortDescending": ": activate to sort column descending"
                },
                "emptyTable": "No data available in table",
                "info": "Showing _START_ to _END_ of _TOTAL_ entries",
                "infoEmpty": "No entries found",
                "infoFiltered": "(filtered from _MAX_ total entries)",
                "lengthMenu": "Show _MENU_ entries",
                "Search": "Search:",
                "zeroRecords": "No matching records found"
            },

            "columnDefs": [{
                "orderable": true,
                "targets": [0]
            }],
            "order": [
                [0, 'asc']
            ],
            "lengthMenu": [
                [5, 15, 20],
                [5, 15, 20] // change per page values here
            ],
            // set the initial value
            "pageLength": 10,
        });
        var tableWrapper = $('#'+varTableID+'_wrapper'); // datatable creates the table wrapper by adding with id {your_table_jd}_wrapper

        tableWrapper.find('.dataTables_length bs-select').select2(); // initialize select2 dropdown

        /* Add event listener for opening and closing details
         * Note that the indicator for showing which row is open is not controlled by DataTables,
         * rather it is done here

         */
        table.on('click', ' tbody td .row-details', function () {
            var nTr = $(this).parents('tr')[0];
            if (oTable.fnIsOpen(nTr)) {
                /* This row is already open - close it */
                $(this).addClass("row-details-close").removeClass("row-details-open");
                oTable.fnClose(nTr);
            } else if(EnableCustomButton==true){
                /* Open this row */
                $(this).addClass("row-details-open").removeClass("row-details-close");
                oTable.fnOpen(nTr, fnCustomFormatDetails(oTable, nTr), 'details');
            }
            else {
                $(this).addClass("row-details-open").removeClass("row-details-close");
                oTable.fnOpen(nTr, fnFormatDetails(oTable, nTr), 'details');
            }
        });
    };

    var initTableWithCustomeOptions = function (DetailRowNeeded,varTableID,EnableCustomButton,RemoveSearchText,ColumnsToExclude,CustomFilterText, CustomDetailContent) {
        var table = $('#'+varTableID);
        var ColumnsToExcludeForSort=ColumnsToExclude==undefined?null:ColumnsToExclude;
        var varFilterinput='';
/*RemoveSearchText is being used to override search option of language in core function to remove search text.*/
        if(CustomFilterText!=undefined)
        {
            varFilterinput= CustomFilterText;
        }
       // alert(ColumnsToExcludeForSort);
        /* Formatting function for row details */
        function fnFormatDetails(oTable, nTr) {
            var aData = oTable.fnGetData(nTr);
            var ihasDangerClass=nTr.className.indexOf('danger');
            var showDeactivetedDetails=false;


            var sOut = '<table class="fr">';
            if(ihasDangerClass !=undefined && ihasDangerClass>-1)
            {
                sOut += '<tr><td ><a href="#"><i class="fa fa-edit"></i> Edit</a></td><td><a href="#" class="text-success"><i class="fa fa-plus-square"></i> Activate</a></td></tr>';
            }
            else
            {   sOut += '<tr><td ><a href="#"><i class="fa fa-edit"></i> Edit</a></td><td><a class="text-danger" data-toggle="modal" data-target="#static" ><i class="fa fa-plus-square"></i> Deactivate</a></td></tr>';
            }
            //sOut += '<tr><td></td><td></td></tr>';
            //sOut += '<tr><td></td><td></td></tr>';
            sOut += '</table>';

            return sOut;
        }

        function fnCustomFormatDetails(oTable, nTr) {
            var aData = oTable.fnGetData(nTr);
            var sOut = '<table style="float:right;">';
            sOut += '<tr><td><a href="extension_request_approve.html" class="text-success"><i class="fa fa-edit"></i> Approve</a></td><td><a href="#" class="text-danger"><i class="fa fa-minus-square"></i> Reject</a></td></tr>';
            //sOut += '<tr><td></td><td></td></tr>';
            //sOut += '<tr><td></td><td></td></tr>';
            sOut += '</table>';

            return sOut;
        }

        function fnCustomFormatDetailsWithContent(oTable, nTr, varContentToAppend) {
            var aData = oTable.fnGetData(nTr);
            var sOut = varContentToAppend;
            //sOut += '<tr><td>'+varContentToAppend+'</td></tr>';
            //sOut += '<tr><td></td><td></td></tr>';
            //sOut += '<tr><td></td><td></td></tr>';
            //sOut += '</table>';

            return sOut;
        }

        /*
         * Insert a 'details' column to the table
         */
        if (DetailRowNeeded == true) {
            var nCloneTh = document.createElement('th');
            nCloneTh.className = "table-checkbox";

            var nCloneTd = document.createElement('td');
            nCloneTd.innerHTML = '<span class="row-details row-details-close"></span>';

            table.find('thead tr').each(function () {
                this.insertBefore(nCloneTh, this.childNodes[0]);
            });

            table.find('tbody tr').each(function () {
                this.insertBefore(nCloneTd.cloneNode(true), this.childNodes[0]);
            });
        }
        /*
         * Initialize DataTables, with no sorting on the 'details' column
         */
        var oTable = table.dataTable({

            // Internationalisation. For more info refer to http://datatables.net/manual/i18n
            "language": {
                "aria": {
                    "sortAscending": ": activate to sort column ascending",
                    "sortDescending": ": activate to sort column descending"
                },
                "emptyTable": "No data available in table",
                "info": "Showing _START_ to _END_ of _TOTAL_ entries",
                "infoEmpty": "No entries found",
                "infoFiltered": "(filtered from _MAX_ total entries)",
                "lengthMenu": "Show _MENU_ entries",
                "Search": "Search:",
                "zeroRecords": "No matching records found"
            },
            "FilterInput":varFilterinput,
            "searchButtonRequired":RemoveSearchText,
            "columnDefs": [{
                "orderable": false,
                "targets": ColumnsToExcludeForSort
            }],
            "order": [
                [0, 'asc']
            ],
            "lengthMenu": [
                [5, 15, 20],
                [5, 15, 20] // change per page values here
            ],
            // set the initial value
            "pageLength": 10,
        });
        var tableWrapper = $('#'+varTableID+'_wrapper'); // datatable creates the table wrapper by adding with id {your_table_jd}_wrapper

        tableWrapper.find('.dataTables_length bs-select').select2(); // initialize select2 dropdown

        /* Add event listener for opening and closing details
         * Note that the indicator for showing which row is open is not controlled by DataTables,
         * rather it is done here

         */
        table.on('click', ' tbody td .row-details', function () {
            var nTr = $(this).parents('tr')[0];
            if (oTable.fnIsOpen(nTr)) {
                /* This row is already open - close it */
                $(this).addClass("row-details-close").removeClass("row-details-open");
                oTable.fnClose(nTr);
            } else if(EnableCustomButton==true){
                /* Open this row */
                $(this).addClass("row-details-open").removeClass("row-details-close");
               if(CustomDetailContent !=undefined && CustomDetailContent!='')
               {
                   oTable.fnOpen(nTr, fnCustomFormatDetailsWithContent(oTable, nTr,CustomDetailContent), 'details');
               }
                else {
                   oTable.fnOpen(nTr, fnCustomFormatDetails(oTable, nTr), 'details');
               }


            }
            else {
                $(this).addClass("row-details-open").removeClass("row-details-close");
                oTable.fnOpen(nTr, fnFormatDetails(oTable, nTr), 'details');
            }
        });
    };

    return {

        //main function to initiate the module
        init: function (DetailRowNeeded,pTableID) {

            if (!jQuery().dataTable) {
                return;
            }

            console.log('me 3');
            initTable3(DetailRowNeeded,pTableID,false);

            console.log('me 3');
        },
        //in case custome buttons needed instead of default buttons
        initCustomButtons: function (DetailRowNeeded,pTableID,EnableCustomButton) {

            if (!jQuery().dataTable) {
                return;
            }

            console.log('me 3');
            initTable3(DetailRowNeeded,pTableID,EnableCustomButton);

            console.log('me 3');
        },
		initCustomButtonsWithoutConfig: function (DetailRowNeeded,pTableID,EnableCustomButton) {

            if (!jQuery().dataTable) {
                return;
            }

            console.log('me 3');
            initTableWithoutConfig(DetailRowNeeded,pTableID,EnableCustomButton);

            console.log('me 3');
        },
        initCustomSortWithFilter:function(DetailRowNeeded,pTableID,EnableCustomButton,HideSearchText,ColumnsToSort,CustomFilterText,CustomDetailContent){
            if (!jQuery().dataTable) {
                return;
            }

            initTableWithCustomeOptions(DetailRowNeeded,pTableID,EnableCustomButton,HideSearchText,ColumnsToSort,CustomFilterText,CustomDetailContent);

            console.log('Custom table function');
        }

    };

}();