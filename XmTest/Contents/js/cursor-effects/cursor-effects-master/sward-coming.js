
//渲染小心心
(function (window, document, undefined) {
    var hearts = [];
    window.requestAnimationFrame = (function () {
        return window.requestAnimationFrame ||
            window.webkitRequestAnimationFrame ||
            window.mozRequestAnimationFrame ||
            window.oRequestAnimationFrame ||
            window.msRequestAnimationFrame ||
            function (callback) {
                setTimeout(callback, 1000 / 60);
            }
    })();
    init();
    function init() {
        css(".heart{width: 10px;height: 10px;position: fixed;background: #f00;transform: rotate(45deg);-webkit-transform: rotate(45deg);-moz-transform: rotate(45deg);}.heart:after,.heart:before{content: '';width: inherit;height: inherit;background: inherit;border-radius: 50%;-webkit-border-radius: 50%;-moz-border-radius: 50%;position: absolute;}.heart:after{top: -5px;}.heart:before{left: -5px;}");
        css(".heart_span{z-index: 999;top:10;left: 5;position: absolute;font-weight:bold;color:#9e3ee4a3;opacity:0.89;font-size:9px;}");
        attachEvent();
        gameloop();
    }
    function gameloop() {
        for (var i = 0; i < hearts.length; i++) {
            if (hearts[i].alpha <= 0) {
                document.body.removeChild(hearts[i].el);
                hearts.splice(i, 1);
                continue;
            }
            hearts[i].y--;
            hearts[i].scale += 0.004;
            hearts[i].alpha -= 0.013;
            hearts[i].el.style.cssText = "left:" + hearts[i].x + "px;top:" + hearts[i].y + "px;opacity:" + hearts[i].alpha + ";transform:scale(" + hearts[i].scale + "," + hearts[i].scale + ") rotate(45deg);background:" + hearts[i].color;
        }
        requestAnimationFrame(gameloop);
    }
    function attachEvent() {
        var old = typeof window.onclick === "function" && window.onclick;
        window.onclick = function (event) {
            old && old();
            createHeart(event);
        }
    }
    function createHeart(event) {
        var d = document.createElement("div");
        d.className = "heart";
        d.appendChild(randomText(event));
        hearts.push({
            el: d,
            x: event.clientX - 5,
            y: event.clientY - 5,
            scale: 1,
            alpha: 1,
            color: randomColor()
        });
        var d2 = document.createElement("div");
        d2.className = "heart";
        hearts.push({
            el: d2,
            x: event.clientX - 17,
            y: event.clientY - 15,
            scale: 1,
            alpha: 1,
            color: randomColor()
        });
        document.body.appendChild(d);
        document.body.appendChild(d2);
    }

    function css(css) {
        var style = document.createElement("style");
        style.type = "text/css";
        try {
            style.appendChild(document.createTextNode(css));
        } catch (ex) {
            style.styleSheet.cssText = css;
        }
        document.getElementsByTagName('head')[0].appendChild(style);
    }
    function randomColor() {
        return "rgb(" + (~~(Math.random() * 255)) + "," + (~~(Math.random() * 255)) + "," + (~~(Math.random() * 255)) + ")";
    }
    var _index = 0;
    function randomText(e) {
        var txts = ["剑来", "小泥人", "春风", "你是我的禅", "秀色可参", "天上剑仙三百万", "见我也须尽低眉", "人生当苦无妨", "江南好"
            , "最好是红衣", "大秦，风起", "万古名", "一杯酒", "不练剑了", "情字最杀人", "苦事,幸事", "一剑仙人跪", "黄花黄", "木马牛",
            "秋风起", "秋叶落", "小二上酒", "当下", "万古如长夜"];
        var randomNum = Math.floor(Math.random() * (txts.length - 1) + 1);
        while (randomNum > txts.length - 1) {
            randomNum = Math.floor(Math.random() * (txts.length - 1) + 1);
        }
        var phrase = new Array("富强", "民主", "和谐", "文明", "自由", "平等", "公正", "法治", "爱国", "敬业", "诚信", "友善");
        _index = (_index + 1) % phrase.length;
        var $span = document.createElement("span");
        $span.textContent = txts[randomNum];//a[a_idx];
        $span.className = "heart_span";
        var x = e.pageX,
            y = e.pageY;
        return $span;
    }
})(window, document);

