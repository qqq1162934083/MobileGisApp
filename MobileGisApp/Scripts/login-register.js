/*
 *
 * login-register modal
 * Autor: Creative Tim
 * Web-autor: creative.tim
 * Web script: #
 * 
 */
function showRegisterForm() {
    $('.loginBox').fadeOut('fast');
    //$('.loginBox').fadeOut('fast',function(){
    //    $('.registerBox').fadeIn('fast');
    //    $('.login-footer').fadeOut('fast',function(){
    //        $('.register-footer').fadeIn('fast');
    //    });
    //    //$('.modal-title').html('Register with');
    //}); 
    //$('.error').removeClass('alert alert-danger').html('');
       
}
function showLoginForm() {
    $('.loginBox').fadeIn('fast');
    //$('#loginModal .registerBox').fadeOut('fast',function(){
    //    $('.loginBox').fadeIn('fast');
    //    $('.register-footer').fadeOut('fast',function(){
    //        $('.login-footer').fadeIn('fast');    
    //    });
        
    //    //$('.modal-title').html('Login with');
    //});       
    // $('.error').removeClass('alert alert-danger').html(''); 
}

function openLoginModal(){
    //showLoginForm();
    $('#loginModal').modal('hide');
    $('#registerModal').modal('hide');

    //if ($('#loginModal').modal)
    setTimeout(function(){
        $('#loginModal').modal('show');    
    }, 230);
}

function openRegisterModal() {
    //showRegisterForm();
    $('#loginModal').modal('hide');
    $('#registerModal').modal('hide');
    setTimeout(function(){
        $('#registerModal').modal('show');    
    }, 230);
    
}

//Òì²½µÇÂ¼
function login() {
    var emailStr = $("#LoginEmail").val();
    var password = $("#LoginPassword").val();
    $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/Login/AccountLogin',
        data: {
            "email": emailStr,
            "password": password
        },
        success: function (result) {
            alert(result.message);
        },
        error: function () {
            alert('error');
        }
    });
}

function shakeModal(){
    $('#loginModal .modal-dialog').addClass('shake');
             $('.error').addClass('alert alert-danger').html("Invalid email/password combination");
             $('input[type="password"]').val('');
             setTimeout( function(){ 
                $('#loginModal .modal-dialog').removeClass('shake'); 
    }, 1000 ); 
}

   