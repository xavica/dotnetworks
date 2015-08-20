//function submitClick() {
//    var email = $('#emailid').val();
//    var password = $('#password').val();
//    console.log(email, password);
//}
var request = require('request');

var options = {
    url: 'http://localhost:52808/token',
    headers: {
        'content-type': 'application/x-www-form-urlencoded'
    },
    body: "username=admin@gmail.com&password=Siva@123&grant_type=password"
};
//request.post(options, function (error, response, body) {
//    if (!error && response.statusCode == 200) {
//        console.log(body);
//    }
//    else {
//        console.log(response.statusCode);
//    }
//});
var accessToken = "Bearer "+"UF3S_cAPCnSAR_i7EY5E9lJj5XWs3kPmB9M7M2sCO2Z6Ia3oGmTzO7Lm40_cpriwQ5XjzFzB0TxRLKTS5qjDAnRHMYPBeiXhxcDaKPdHgE7ELBZlPCK2RmI7XY4s0sG2LtGMZPMWUJauiRl3MLMadjw013SPKNW4zOAz7Hyuc3XOntQbIyVONEqfuMpDBN2IL5H4h86kiseICbG8WdPyU2CZ19ZmaHNBghx11fkXSHtPKBMBZUDMGaLOPnUZ69f-ujC8YFPN4CuT9c6J6BjfC_iCdUh_yf83OA0iv2Myp65Eb_BSuuHwZpB2lLUoOdjoRk_Q2iEMexbcrncevVx1xOby6lfy43IUyJ5S9ey-8hzHW1KnvUCghc8Vu8nC-qMC9CcOC-EAl4m0WTKwFbnrxyr6ib80hd3Gvr3tExzMwd8aqOa29-q5SFm-1fgwFIJiKKSwydQUkGwA_jHkli1_eQzHBYONlmTgFu8PFHONO3o",
    valueOptions = {
        url: 'http://localhost:52808/api/values',
        headers: {
            'Authorization': accessToken
        },
    }
request.get(valueOptions, function (error, response, body) {
    if (!error && response.statusCode == 200) {
        console.log(body);
    }
    else {
        console.log(response.statusCode);
    }
});