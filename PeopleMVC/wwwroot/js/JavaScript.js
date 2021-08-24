let baseUrl = window.location.origin;

function deletePerson(id) {
    $.ajax({
        url: `${baseUrl}/people/${id}`,
        type: 'DELETE',
        success: function (result) {
            window.location.href = `${baseUrl}/people/index`
        }
    });
}