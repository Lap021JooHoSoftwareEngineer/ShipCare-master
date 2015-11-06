$(document)
    .ready(function () {
        $("#login").click(function () {
            $('.ui.form').form({
                fields: {
                    email: {
                        identifier: 'email',
                        rules: [{
                            type: 'empty',
                            prompt: '아이디를 입력해주세요.'
                        }, {
                            type: 'empty',
                            prompt: '정확한 아이디가 아닙니다.'
                        }]
                    },
                    password: {
                        identifier: 'password',
                        rules: [{
                            type: 'empty',
                            prompt: '비밀번호를 입력하세요.'
                        }, {
                            type: 'length[6]',
                            prompt: '비밀번호는 6자 이상이어야 합니다.'
                        }]
                    }
                }
            });
        });
    });