# willisweb

Lightweight SPA landing page for [willisweb.com](https://willisweb.com).

## Overview

A pure HTML/CSS single-page landing site — no build step, no framework, no bundler. Just a clean welcome page served as a static site via Vercel.

## Project structure

```
.
├── index.html      # Main (and only) page
├── style.css       # All styles
├── vercel.json     # Vercel deployment config (headers, routing)
└── README.md
```

## Local preview

Open `index.html` directly in a browser, or use any static-file server:

```bash
npx serve .
# → http://localhost:3000
```

## Deploying to Vercel

1. Connect this repository to a Vercel project (the free Hobby plan is sufficient).
2. Vercel will detect the static site automatically — no build command or output directory is required.
3. Add the custom domain `willisweb.com` in the Vercel project settings.
