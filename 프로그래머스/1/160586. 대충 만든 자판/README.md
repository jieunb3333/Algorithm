# [level 1] 대충 만든 자판 - 160586 

[문제 링크](https://school.programmers.co.kr/learn/courses/30/lessons/160586?language=csharp) 

### 성능 요약

메모리: 31.4 MB, 시간: 2.46 ms

### 구분

코딩테스트 연습 > 연습문제

### 채점결과

정확성: 100.0<br/>합계: 100.0 / 100.0

### 제출 일자

2024년 03월 05일 12:31:26

### 문제 설명

<p style="user-select: auto !important;">휴대폰의 자판은 컴퓨터 키보드 자판과는 다르게 하나의 키에 여러 개의 문자가 할당될 수 있습니다. 키 하나에 여러 문자가 할당된 경우, 동일한 키를 연속해서 빠르게 누르면 할당된 순서대로 문자가 바뀝니다. </p>

<p style="user-select: auto !important;">예를 들어, 1번 키에 "A", "B", "C" 순서대로 문자가 할당되어 있다면 1번 키를 한 번 누르면 "A", 두 번 누르면 "B", 세 번 누르면 "C"가 되는 식입니다. </p>

<p style="user-select: auto !important;">같은 규칙을 적용해 아무렇게나 만든 휴대폰 자판이 있습니다. 이 휴대폰 자판은 키의 개수가 1개부터 최대 100개까지 있을 수 있으며, 특정 키를 눌렀을 때 입력되는 문자들도 무작위로 배열되어 있습니다. 또, 같은 문자가 자판 전체에 여러 번 할당된 경우도 있고, 키 하나에 같은 문자가 여러 번 할당된 경우도 있습니다. 심지어 아예 할당되지 않은 경우도 있습니다. 따라서 몇몇 문자열은 작성할 수 없을 수도 있습니다. </p>

<p style="user-select: auto !important;">이 휴대폰 자판을 이용해 특정 문자열을 작성할 때, 키를 최소 몇 번 눌러야 그 문자열을 작성할 수 있는지 알아보고자 합니다. </p>

<p style="user-select: auto !important;">1번 키부터 차례대로 할당된 문자들이 순서대로 담긴 문자열배열 <code style="user-select: auto !important;">keymap</code>과 입력하려는 문자열들이 담긴 문자열 배열 <code style="user-select: auto !important;">targets</code>가 주어질 때, 각 문자열을 작성하기 위해 키를 최소 몇 번씩 눌러야 하는지 순서대로 배열에 담아 return 하는 solution 함수를 완성해 주세요. </p>

<p style="user-select: auto !important;">단, 목표 문자열을 작성할 수 없을 때는 -1을 저장합니다.</p>

<hr style="user-select: auto !important;">

<h5 style="user-select: auto !important;">제한사항</h5>

<ul style="user-select: auto !important;">
<li style="user-select: auto !important;">1 ≤ <code style="user-select: auto !important;">keymap</code>의 길이 ≤ 100

<ul style="user-select: auto !important;">
<li style="user-select: auto !important;">1 ≤ <code style="user-select: auto !important;">keymap</code>의 원소의 길이 ≤ 100</li>
<li style="user-select: auto !important;"><code style="user-select: auto !important;">keymap[i]</code>는 i + 1번 키를 눌렀을 때 순서대로 바뀌는 문자를 의미합니다.

<ul style="user-select: auto !important;">
<li style="user-select: auto !important;">예를 들어 <code style="user-select: auto !important;">keymap[0]</code> = "ABACD" 인 경우 1번 키를 한 번 누르면 A, 두 번 누르면 B, 세 번 누르면 A 가 됩니다.</li>
</ul></li>
<li style="user-select: auto !important;"><code style="user-select: auto !important;">keymap</code>의 원소의 길이는 서로 다를 수 있습니다.</li>
<li style="user-select: auto !important;"><code style="user-select: auto !important;">keymap</code>의 원소는 알파벳 대문자로만 이루어져 있습니다.</li>
</ul></li>
<li style="user-select: auto !important;">1 ≤ <code style="user-select: auto !important;">targets</code>의 길이 ≤ 100

<ul style="user-select: auto !important;">
<li style="user-select: auto !important;">1 ≤ <code style="user-select: auto !important;">targets</code>의 원소의 길이 ≤ 100</li>
<li style="user-select: auto !important;"><code style="user-select: auto !important;">targets</code>의 원소는 알파벳 대문자로만 이루어져 있습니다.</li>
</ul></li>
</ul>

<hr style="user-select: auto !important;">

<h5 style="user-select: auto !important;">입출력 예</h5>
<table class="table" style="user-select: auto !important;">
        <thead style="user-select: auto !important;"><tr style="user-select: auto !important;">
<th style="user-select: auto !important;">keymap</th>
<th style="user-select: auto !important;">targets</th>
<th style="user-select: auto !important;">result</th>
</tr>
</thead>
        <tbody style="user-select: auto !important;"><tr style="user-select: auto !important;">
<td style="user-select: auto !important;">["ABACD", "BCEFD"]</td>
<td style="user-select: auto !important;">["ABCD","AABB"]</td>
<td style="user-select: auto !important;">[9, 4]</td>
</tr>
<tr style="user-select: auto !important;">
<td style="user-select: auto !important;">["AA"]</td>
<td style="user-select: auto !important;">["B"]</td>
<td style="user-select: auto !important;">[-1]</td>
</tr>
<tr style="user-select: auto !important;">
<td style="user-select: auto !important;">["AGZ", "BSSS"]</td>
<td style="user-select: auto !important;">["ASA","BGZ"]</td>
<td style="user-select: auto !important;">[4, 6]</td>
</tr>
</tbody>
      </table>
<hr style="user-select: auto !important;">

<h5 style="user-select: auto !important;">입출력 예 설명</h5>

<p style="user-select: auto !important;">입출력 예 #1 </p>

<ul style="user-select: auto !important;">
<li style="user-select: auto !important;">"ABCD"의 경우, </li>
<li style="user-select: auto !important;">1번 키 한 번 → A </li>
<li style="user-select: auto !important;">2번 키 한 번 → B </li>
<li style="user-select: auto !important;">2번 키 두 번 → C </li>
<li style="user-select: auto !important;">1번 키 다섯 번 → D </li>
<li style="user-select: auto !important;">따라서 총합인 9를 첫 번째 인덱스에 저장합니다. </li>
<li style="user-select: auto !important;">"AABB"의 경우, </li>
<li style="user-select: auto !important;">1번 키 한 번 → A </li>
<li style="user-select: auto !important;">1번 키 한 번 → A </li>
<li style="user-select: auto !important;">2번 키 한 번 → B </li>
<li style="user-select: auto !important;">2번 키 한 번 → B </li>
<li style="user-select: auto !important;">따라서 총합인 4를 두 번째 인덱스에 저장합니다. </li>
<li style="user-select: auto !important;">결과적으로 [9,4]를 return 합니다. </li>
</ul>

<p style="user-select: auto !important;">입출력 예 #2 </p>

<ul style="user-select: auto !important;">
<li style="user-select: auto !important;">"B"의 경우, 'B'가 어디에도 존재하지 않기 때문에 -1을 첫 번째 인덱스에 저장합니다. </li>
<li style="user-select: auto !important;">결과적으로 [-1]을 return 합니다. </li>
</ul>

<p style="user-select: auto !important;">입출력 예 #3 </p>

<ul style="user-select: auto !important;">
<li style="user-select: auto !important;">"ASA"의 경우, </li>
<li style="user-select: auto !important;">1번 키 한 번 → A </li>
<li style="user-select: auto !important;">2번 키 두 번 → S </li>
<li style="user-select: auto !important;">1번 키 한 번 → A </li>
<li style="user-select: auto !important;">따라서 총합인 4를 첫 번째 인덱스에 저장합니다. </li>
<li style="user-select: auto !important;">"BGZ"의 경우, </li>
<li style="user-select: auto !important;">2번 키 한 번 → B </li>
<li style="user-select: auto !important;">1번 키 두 번 → G </li>
<li style="user-select: auto !important;">1번 키 세 번 → Z </li>
<li style="user-select: auto !important;">따라서 총합인 6을 두 번째 인덱스에 저장합니다. </li>
<li style="user-select: auto !important;">결과적으로 [4, 6]을 return 합니다.</li>
</ul>


> 출처: 프로그래머스 코딩 테스트 연습, https://school.programmers.co.kr/learn/challenges