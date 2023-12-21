# How to notify slack message when merge

```yaml
on:
  pull_request:
    types:
      - closed

jobs:
  if_merged:
    if: github.event.pull_request.merged == true && contains(github.event.pull_request.labels.*.name, 'documentation')
    runs-on: ubuntu-latest
    steps:
      - name: Slack Notification
        uses: rtCamp/action-slack-notify@v2
        env:
          SLACK_TITLE: "PR merged with new documentation"
          SLACK_WEBHOOK: ${{ secrets.SLACK_WEBHOOK }}
```

# Reference

https://github.com/marketplace/actions/slack-notify

https://docs.github.com/en/graphql/reference/objects#pullrequest
