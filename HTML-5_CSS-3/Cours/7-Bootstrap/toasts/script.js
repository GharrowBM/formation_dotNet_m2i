
var toastTrigger = document.getElementById('liveToastBtn')
var toastLiveExample = document.getElementById('liveToast')

if (toastTrigger) {
  toastTrigger.addEventListener('click', function () {
    var toast = new bootstrap.Toast(toastLiveExample)

    toast.show()
  })
}




$(document).ready(function(){
  $("#bouton1").click(function(){
    $('#toast1').toast('show');
  });
});


$(document).ready(function(){
  $("#bouton2").click(function(){
    $('#toast2').toast('show');
  });
});

$(document).ready(function(){
  $("#bouton3").click(function(){
    $('#toast3').toast('show');
  });
});

$(document).ready(function(){
  $("#bouton4").click(function(){
    $('#toast4').toast('show');
  });
});

$(document).ready(function(){
  $("#bouton5").click(function(){
    $('#toast5').toast('show');
  });
});

$(document).ready(function(){
  $("#bouton6").click(function(){
    $('#toast6').toast('show');
  });
});

$(document).ready(function(){
  $("#bouton7").click(function(){
    $('#toast7').toast('show');
  });
});

