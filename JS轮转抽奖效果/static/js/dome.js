$(function () {
    DomeWebController.init();
});


DomeWebController = {
    pool: {
        element: {}
    },
    getEle: function (k) {
        return DomeWebController.pool.element[k];
    },
    setEle: function (k, v) {
        DomeWebController.pool.element[k] = v;
    },
    init: function () {
        var that = DomeWebController;
        that.inits.element();
        that.inits.event();
        that.build();
    },
    inits: {
        element: function () {
            var that = DomeWebController;
            that.setEle("$wheelContainer", $('#wheel_container'));

        },
        event: function () {
            var that = DomeWebController;

        }
    },
    build: function () {
        var that = DomeWebController;
        that.getEle("$wheelContainer").wheelOfFortune({
            'wheelImg': "static/img/wheel_1/disk.png",//转轮图片
            'pointerImg': "static/img/wheel_1/pointer.png",//指针图片
            'buttonImg': "static/img/wheel_1/button.png",//开始按钮图片
            //'wSide': 400,//转轮边长(默认使用图片宽度)
            //'pSide': 191,//指针边长(默认使用图片宽度)
            //'bSide': 87,//按钮边长(默认使用图片宽度)
            'items': { 0: [121, 180], 1: [181, 240], 2: [241, 300], 3: [301, 360], 4: [1, 60], 5: [61, 120] },//奖品角度配置{键:[开始角度,结束角度],键:[开始角度,结束角度],......}
            'pAngle': 210,//指针图片中的指针角度(x轴正值为0度，顺时针旋转 默认0)
            //'type': 'w',//旋转指针还是转盘('p'指针 'w'转盘 默认'p')
            //'fluctuate': 0.5,//停止位置距角度配置中点的偏移波动范围(0-1 默认0.8)
            //'rotateNum': 12,//转多少圈(默认12)
            //'duration': 6666,//转一次的持续时间(默认5000)
            'click': function () {
                var index = parseInt(Math.random() * 100) + 1;
                if (index == 100) {
                    key = 0;
                } else if (index >= 95 && index < 100) {
                    key = 1;
                } else if (index >= 85 && index < 95) {
                    key = 2;
                } else if (index >= 70 && index < 85) {
                    key = 3;
                } else if (index >= 50 && index < 70) {
                    key = 4;
                } else if (index >= 25 && index < 50) {
                    key = 4;
                } else {
                    key = 5;
                }
                that.getEle("$wheelContainer").wheelOfFortune('rotate', key, 'w');
            },//点击按钮的回调
            'rotateCallback': function (key) {
                if (key == 0) {
                    key = "特等奖";
                } else if (key == 1) {
                    key = "一等奖";
                } else if (key == 2) {
                    key = "二等奖";
                } else if (key == 3) {
                    key = "三等奖";
                } else if (key == 4) {
                    key = "四等奖";
                } else if (key == 5) {
                    key = "谢谢惠顾";
                } else {
                    key = "谢谢惠顾";
                }
                if (key!="谢谢惠顾") {
                    alert("恭喜您，您中了" + key);
                } else {
                    alert("很遗憾，您什么也没抽中");
                }

            }//转完的回调
        });

    }
};