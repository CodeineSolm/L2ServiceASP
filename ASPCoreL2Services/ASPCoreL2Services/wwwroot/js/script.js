function SetImg(selected_url)
{
    var item = document.getElementById('previewpic');
    item.src = selected_url;
}

function SubmitForm(name,tel,car)
{
    $.ajax({
        method:"POST", url:"/Home/Order",
        data:{Name:name,Tel:tel,Services:services}
    }).fail(function(){
        alert("При передаче данных произошла ошибка!");
    }).done(function(context){
        alert(context)
    });
}

$(document).ready(function()
{
    $('#header').fadeTo(700,0.7,function()
    {
        $('html, body').animate({scrollTop: $('body').height()}, 700);
    });
});