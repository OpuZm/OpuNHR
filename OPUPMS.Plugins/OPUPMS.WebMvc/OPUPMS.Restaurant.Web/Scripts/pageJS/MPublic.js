var winW = $(window).width();
var winH = $(window).height();


//获取URL参数
function getUrlParam(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"); //构造一个含有目标参数的正则表达式对象
    var r = window.location.search.substr(1).match(reg);  //匹配目标参数
    if (r != null) return unescape(r[2]); return null; //返回参数值
}


//自适应  T
function T_list_auto(operation,mealTable){
	//点菜操作菜单
	if(operation){
		var minHeight = 50;  //最小高度
		var winHeight = $(window).height();
		var $operation_li = $('#operation_lists').children('li');
		var len = $operation_li.length;
		
		var $operation_li_h = ( winHeight - len * 2 - 2) / len;
		
		$operation_li_h < minHeight ? $operation_li_h = minHeight + 'px' : $operation_li_h > 100 ? $operation_li_h = '100px' : $operation_li_h += 'px';
		
		$operation_li.children('a').css({'height':$operation_li_h,'line-height':$operation_li_h});
	}
	
	
}

//获取当前时间
function gettime() {
    var d = new Date();
    var month = d.getMonth() + 1;
    var day = d.getDate();
    var minutes = d.getMinutes();
    var seconds = d.getSeconds();
    var time = d.getHours() + ":" + (minutes < 10 ? '0' : '') + minutes + ":" + (seconds < 10 ? '0' : '') + seconds;
    var date = d.getFullYear() + '-' + (month < 10 ? '0' : '') + month + '-' + (day < 10 ? '0' : '') + day;
    var datatime = date + ' ' + time;
    return datatime;
}

//判断对象是否为空
function isEmptyObject(obj) {   
　　for (var key in obj){
　　　　return false;//返回false，不为空对象
　　}　　
　　return true;//返回true，为空对象
}


//打单弹窗
function printLayer(option){
	var url = 'http://139.9.40.110:996/report/show?'
	option.key['RestaurantName'] = inidata.RestaurantName;
	option.key['OperatorName'] = inidata.UserName;
	option.key['MarketName'] = inidata.MarketName;
	option.key['BusinessDate'] = BusinessDate;
	for(let i in option.key){
		url += i + '=' + option.key[i] + '&';
	}
	url = url.substring(0, url.length - 1);
	layer.open({
        type: 2,
        title: option.title,
        shadeClose: true,
        shade: 0.8,
        area: ['80%', '80%'],
        content: url,
        cancel: function (index, layero) {
        },
        end: function (layero) {
            
        }
    });
	console.log(url)
}
