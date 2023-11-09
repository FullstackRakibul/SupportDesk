/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./src/**/*.{js,jsx,ts,tsx}",
  ],
  theme: {
    extend: {},
    screens: {
      'sm': '576px',
      'md': '960px',
      'lg': '1440px',
    },
    colors: {
      primary: '#3A5162',
      secondary: '#6E4441',
      white: '#fff',
      black: '#000',
      bgColor : '#F9FFFE',

    }
  },
  plugins: [],
}

