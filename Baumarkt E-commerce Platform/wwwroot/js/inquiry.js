var dataTable;

$(document).ready(function () {

    LoadDataTable();

});

function LoadDataTable(url) {

dataTable = $('#tblData').DataTable({
        "ajax": {
        "url": "/Inquiry/GetInquiryLIst/" + url
        },
        "columns": [
            { "data": "id", "width": "10%" },
            { "data": "fullName", "width": "15%" },
            { "data": "phoneNumber", "width": "15%" },
            { "data": "email", "width": "15%" },
            { "data": "inquiryHeader", "width": "15%" },
            { "data": "inquiryDetails", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                            <div class="text-center">
                                <a href="/*/Admin*//Inquiry/Details/${data}" class="btn btn-success text-white" style="cursor:pointer">
                                    <i class="fas fa-edit"></i>
                                </a>
                            </div>
                           `;
                }, "width": "15%"
            }
        ]
    });

}
