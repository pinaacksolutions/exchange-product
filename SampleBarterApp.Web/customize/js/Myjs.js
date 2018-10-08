
function showImage(imgName) {
    var curImage = document.getElementById('currentImg');
    var thePath = '/customize/img/';
    var theSource = thePath + imgName;

    curImage.src = theSource;
    curImage.alt = imgName;
    curImage.title = imgName;
}

function showHideNeedItemSection()
{
    if (document.getElementById('need').checked)
    {
        document.getElementById('Needitems').style.display = 'block';
    }
    else {
        document.getElementById('Needitems').style.display = 'none';
    }

}

$(document).ready(function () {







    $('.test').hide();
    $('#btnshow').click(function () {
        $('.test').show();
        $('#btnshow').hide();
    })

    //Navbar Active link
    //$('.navbar-nav .nav-link').click(function () {
    //    debugger;
    //    $('li a').removeClass('active');
    //    $(this).addClass('active');
    //    debugger;
    //    localStorage.setItem('active', $(this).parent().index());
    //})
    //var ele = localStorage.getItem('active');
    //$('#collapsibleNavbar ul li:eq(' + ele + ')').find('a').addClass('active');

    //Dashboard side bar Active link

    //$('.list-unstyled .testnvalink').click(function () {
    //    debugger;
    //    $('li a').removeClass('backcolor');
    //    $(this).addClass('backcolor');
    //    localStorage.setItem('backcolor', $(this).parent().index());
    //})
    //var ele = localStorage.getItem('backcolor');
    //debugger;
    //$('#siderbar ul li:eq(' + ele + ')').find('a').addClass('backcolor');

    $(function () {
        var current = location.pathname;
        $('#siderbar ul li a').each(function () {
            var $this = $(this);
            // if the current path is like this link, make it active
            if ($this.attr('href').indexOf(current) !== -1) {
                $this.addClass('backcolor');
            }
        })
        $('#collapsibleNavbar ul li a').each(function () {
            var $this = $(this);
            // if the current path is like this link, make it active
            if ($this.attr('href').indexOf(current) !== -1) {
                $this.addClass('active');
            }
        })

    })


})













