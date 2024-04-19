/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./Src/**/*.{html,cshtml,js}", "/Pages/**/*.{html,cshtml,js}", "/wwwroot/**/*.{html,cshtml,js}"],
  theme: {
    extend: {},
  },
    plugins: [
    ],
    purge: {
        enabled: true,
        content: [
            './Pages/**/*.cshtml',
            './Views/**/*.cshtml'
        ]
    },
}

