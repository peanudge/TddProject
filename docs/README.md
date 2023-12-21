# How to TDD

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
