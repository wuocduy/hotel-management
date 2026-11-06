document.querySelectorAll("[data-demo-form]").forEach((form) => {
    form.addEventListener("submit", (event) => {
        event.preventDefault();

        const message = form.querySelector(".demo-message");
        const password = form.querySelector("[name='password']");
        const confirmPassword = form.querySelector("[name='confirmPassword']");

        if (confirmPassword && password.value !== confirmPassword.value) {
            message.textContent = "Mật khẩu xác nhận chưa khớp.";
            message.hidden = false;
            return;
        }

        message.textContent = form.dataset.demoMessage;
        message.hidden = false;
    });
});
