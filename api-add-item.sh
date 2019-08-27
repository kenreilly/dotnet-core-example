#!/bin/bash
curl -H "Content-type: application/json" -X POST http://localhost:5000/api/items -d "{\"name\":\"$1\",\"description\":\"$2\"}"