# Labeler Guide

> https://github.com/actions/labeler

```
documentation:
  - changed-files:
      - any-glob-to-any-file: "docs/*"

source:
  - changed-files:
      - all-globs-to-all-files:
          - "!docs/*"
          - "!.github/*"
          - "**"

```
