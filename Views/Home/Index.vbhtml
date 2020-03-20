@Code
    ViewData("Title") = "Home Page"
End Code

    <div class="jumbotron">
        <div class="container">
            <form asp-controller="Tasks" asp-action="Index" method="get" class="form-horizontal" role="form">
                <div>
                    <label asp-for="CategoryId"></label>
                    <select asp-for="CategoryId"
                            asp-items="Model.CategoryOptions">
                        <option>Any category</option>
                    </select>
                </div>
                <div>
                    <button type="submit" class="btn btn-default">Filter tasks &raquo;</button>
                </div>
            </form>
        </div>
    </div>

<table class="table">
    <tr>
        <th></th>
        <th>Task</th>
        <th>Category</th>
        <th></th>
    </tr>

 
</table>