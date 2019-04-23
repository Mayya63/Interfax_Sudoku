
 function getCookie(name) {
        var matches = document.cookie.match(new RegExp(
            "(?:^|; )" + name.replace(/([\.$?*|{}\(\)\[\]\\\/\+^])/g, '\\$1') + "=([^;]*)"
        ));
        return matches ? decodeURIComponent(matches[1]) : undefined;
    }
    function readArrayFromCookie() {
        var dataArr = getCookie('arr');//считываем данные из куков
        //если массив небы обнаружен, иницилизируем его
        if (dataArr === null || dataArr === undefined) {
            dataArr = JSON.stringify(new Array());
            document.cookie = 'arr=' + dataArr;
            // инициализированный пустой маасив
        }
        //возвращаем полученный массив
        return JSON.parse(dataArr);
    }
    function addArrayToCookie(obj) {
        var arr = readArrayFromCookie();//получаем текущее состояние массива
        if (arr.includes(obj)) {
            return;
        }
        arr[arr.length] = obj; //добавляем элемент в конец
        var str = JSON.stringify(arr);//конвертируем в строку
        document.cookie = 'arr=' + str;//записываем массив в куки
    }


