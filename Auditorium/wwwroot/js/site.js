$(function ()
{
	//alert("OK!");

	$(".label__kids").addClass("unselected");

	$("body").on("click", ".input__kids", function()
	{
		var seatId = $(this).attr("data-id");
		$(".label__kids[data-id=" + seatId + "]").toggleClass("unselected selected");
	});

    $.ajax(
        {
            type: "GET",
            url: "../Home/GetSeats",
            dataType: "json",
            success: function(response)
            {
                var content = "";
                var rowsCount = response[0].rowsCount;
                var placesCount = response[0].placesCount;
                for (var i = 1; i <= rowsCount; i++)
                {
                    for (var j = 1; j <= placesCount; j++)
                    {
                        content +=
                            '<label data-id="' + i + '_' + j + '" class="label__kids unselected" for="a">' +
                            '<input data-id="' + i + '_' + j + '" class="input__kids" type="checkbox" value="' + i + '_' + j + '" name="seat" id="a">' +
                            '</label>';
                    }
                    content += '<br>';
                }

                $("#rows_and_places").html(content);
            },
            error: function(xml) { alert("error") }
        });
})