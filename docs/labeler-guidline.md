# Labeler Guide

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

# References

> https://github.com/actions/labeler
