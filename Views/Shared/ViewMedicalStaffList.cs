//namespace Hospital_Managment.Views.Home;
@model IEnumerable<HospitalManagment.Models.MedicalStaff>

public class ViewMedicalStaffList
{
    <table class="table table-striped">
    <thead>
        <tr>
            <th>#</th>
            <th>Name</th>
            <th>Position</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var staff in Model)
        {
            <tr>
                <td>@staff.Id</td>
                <td>@staff.Username</td>
                <td>@staff.Position</td>
            </tr>
        }
    </tbody>
</table>
}