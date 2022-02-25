var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Product/GetAll"
        },
        "columns": [
            {"data" : "title", "width" : "15%"},
            {"data" : "isbn", "width" : "15%"},
            {"data" : "price", "width" : "15%"},
            {"data" : "author", "width" : "15%"},
            {"data" : "category.name", "width" : "15%"},
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <td>
                        <div class="w-75 btn-group" role="group">
                            <a href="/Admin/Product/Upsert?id=${data}" class="btn btn-outline-info"><i class="bi bi-pencil-square"></i>Edit</a>

                            <a href="/Admin/Product/Upsert?id=${data}" class="btn btn-outline-danger"><i class="bi bi-trash-fill"></i>Delete</a>
                        </div>
                    </td>
                    `
                },
                "width" : "15%"
            },

        ]
    })
}