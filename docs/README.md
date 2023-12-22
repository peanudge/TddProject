# How to notify slack message when merge

```yaml
on:
  pull_request:
    types:
      - closed

jobs:
  if_merged:
    if: github.event.pull_request.merged == true && contains(github.event.pull_request.labels.*.name, 'migrations')
    runs-on: ubuntu-latest
    steps:
      - name: Notification
        run: echo The PR was merged
```

# Reference

https://docs.github.com/en/graphql/reference/objects#pullrequest
