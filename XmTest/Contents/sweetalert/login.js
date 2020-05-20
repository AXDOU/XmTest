//var baseUrl = "http://127.0.0.1:8077"
var baseUrl = "http://111.231.203.45:8077"
//var baseUrl = "http://129.211.158.222:8077"

var loginData = JSON.parse(sessionStorage.getItem("LOGININFO"));
if(loginData == null && loginData == undefined){
}else{
//	window.location.href="http://127.0.0.1:8020/WjcWebs/index.html"
//	window.location.href="http://www.tz123456.com/index.html"
window.location.href="http://111.231.203.45/index.html"
}
function sumbit() {
	var userName = $("#userName").val();
	var password = $("#password").val();
	if(userName.length > 0 && password.length > 0) {
		var data = {
			userName: userName,
			password: password
		};
		$.ajax({        
			url: baseUrl + "/webApi/base/webLogin",
			        type: "post",
			data: data,
			        dataType: 'json',
			        success: function(result) {          
				if(result.code === "0") {
					swal({
							title:result.msg,
							type: "success",
							showCancelButton: false,
							confirmButtonColor: "#DD6B55",
							confirmButtonText: "确定",
							closeOnConfirm: false
						},
						function() {
							sessionStorage.setItem("LOGININFO", JSON.stringify(result.data));            
							window.location.href = "index.html";          

						});
					
				} else {            
					swal("提示", result.msg, "error")          
				}        
			}      
		});
	} else {
		swal("提示", "账号密码不能为空!", "error")
	}
}