<<<<<<< HEAD
// Kasper College - Vanilla JavaScript Interactivity & Accessibility Enhancements

document.addEventListener("DOMContentLoaded", function () {
    // 1. Mobile Navigation Menu Toggle
    const menuToggle = document.getElementById("menu-toggle");
    const primaryNav = document.getElementById("primary-nav");

    if (menuToggle && primaryNav) {
        menuToggle.addEventListener("click", function () {
            const isOpen = primaryNav.classList.toggle("is-open");
            menuToggle.setAttribute("aria-expanded", isOpen ? "true" : "false");
        });
    }

    // 2. Client-Side Form Validation on Contact Page
    const contactForm = document.getElementById("contact-form");
    if (contactForm) {
        contactForm.addEventListener("submit", function (event) {
            let isValid = true;

            const nameInput = document.getElementById("FullName");
            const emailInput = document.getElementById("Email");
            const messageInput = document.getElementById("Message");

            const nameError = document.getElementById("error-FullName");
            const emailError = document.getElementById("error-Email");
            const messageError = document.getElementById("error-Message");

            // Clear previous errors
            nameError.textContent = "";
            emailError.textContent = "";
            messageError.textContent = "";

            if (!nameInput.value.trim()) {
                nameError.textContent = "Please enter your full name.";
                isValid = false;
            }

            if (!emailInput.value.trim() || !emailInput.value.includes("@")) {
                emailError.textContent = "Please enter a valid email address.";
                isValid = false;
            }

            if (!messageInput.value.trim()) {
                messageError.textContent = "Please enter your message.";
                isValid = false;
            }

            if (!isValid) {
                event.preventDefault();
            }
        });
    }
});
=======
﻿// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
>>>>>>> c02d0b519319d5054ac35f57b16d7759e5ed3101
