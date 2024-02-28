# [level 1] 가장 비싼 상품 구하기 - 131697 

[문제 링크](https://school.programmers.co.kr/learn/courses/30/lessons/131697) 

### 성능 요약

메모리: 0.0 MB, 시간: 0.00 ms

### 구분

코딩테스트 연습 > SUM， MAX， MIN

### 채점결과

Empty

### 제출 일자

2024년 02월 28일 16:49:46

### 문제 설명

<p style="user-select: auto !important;">다음은 어느 의류 쇼핑몰에서 판매 중인 상품들의 정보를 담은 <code style="user-select: auto !important;">PRODUCT</code> 테이블입니다. <code style="user-select: auto !important;">PRODUCT</code> 테이블은 아래와 같은 구조로 되어있으며, <code style="user-select: auto !important;">PRODUCT_ID</code>, <code style="user-select: auto !important;">PRODUCT_CODE</code>, <code style="user-select: auto !important;">PRICE</code>는 각각 상품 ID, 상품코드, 판매가를 나타냅니다.</p>
<table class="table" style="user-select: auto !important;">
        <thead style="user-select: auto !important;"><tr style="user-select: auto !important;">
<th style="user-select: auto !important;">Column name</th>
<th style="user-select: auto !important;">Type</th>
<th style="user-select: auto !important;">Nullable</th>
</tr>
</thead>
        <tbody style="user-select: auto !important;"><tr style="user-select: auto !important;">
<td style="user-select: auto !important;">PRODUCT_ID</td>
<td style="user-select: auto !important;">INTEGER</td>
<td style="user-select: auto !important;">FALSE</td>
</tr>
<tr style="user-select: auto !important;">
<td style="user-select: auto !important;">PRODUCT_CODE</td>
<td style="user-select: auto !important;">VARCHAR(8)</td>
<td style="user-select: auto !important;">FALSE</td>
</tr>
<tr style="user-select: auto !important;">
<td style="user-select: auto !important;">PRICE</td>
<td style="user-select: auto !important;">INTEGER</td>
<td style="user-select: auto !important;">FALSE</td>
</tr>
</tbody>
      </table>
<p style="user-select: auto !important;">상품 별로 중복되지 않는 8자리 상품코드 값을 가지며, 앞 2자리는 카테고리 코드를 의미합니다.</p>

<hr style="user-select: auto !important;">

<h5 style="user-select: auto !important;">문제</h5>

<p style="user-select: auto !important;"><code style="user-select: auto !important;">PRODUCT</code> 테이블에서 판매 중인 상품 중 가장 높은 판매가를 출력하는 SQL문을 작성해주세요. 이때 컬럼명은 MAX_PRICE로 지정해주세요.</p>

<hr style="user-select: auto !important;">

<h5 style="user-select: auto !important;">예시</h5>

<p style="user-select: auto !important;">예를 들어 <code style="user-select: auto !important;">PRODUCT</code> 테이블이 다음과 같다면</p>
<table class="table" style="user-select: auto !important;">
        <thead style="user-select: auto !important;"><tr style="user-select: auto !important;">
<th style="user-select: auto !important;">PRODUCT_ID</th>
<th style="user-select: auto !important;">PRODUCT_CODE</th>
<th style="user-select: auto !important;">PRICE</th>
</tr>
</thead>
        <tbody style="user-select: auto !important;"><tr style="user-select: auto !important;">
<td style="user-select: auto !important;">1</td>
<td style="user-select: auto !important;">A1000001</td>
<td style="user-select: auto !important;">10000</td>
</tr>
<tr style="user-select: auto !important;">
<td style="user-select: auto !important;">2</td>
<td style="user-select: auto !important;">A2000005</td>
<td style="user-select: auto !important;">9000</td>
</tr>
<tr style="user-select: auto !important;">
<td style="user-select: auto !important;">3</td>
<td style="user-select: auto !important;">C1000006</td>
<td style="user-select: auto !important;">22000</td>
</tr>
</tbody>
      </table>
<p style="user-select: auto !important;">가장 높은 판매가는 22,000 원 이므로, 다음과 같은 결과가 나와야 합니다.</p>
<table class="table" style="user-select: auto !important;">
        <thead style="user-select: auto !important;"><tr style="user-select: auto !important;">
<th style="user-select: auto !important;">MAX_PRICE</th>
</tr>
</thead>
        <tbody style="user-select: auto !important;"><tr style="user-select: auto !important;">
<td style="user-select: auto !important;">22000</td>
</tr>
</tbody>
      </table>

> 출처: 프로그래머스 코딩 테스트 연습, https://school.programmers.co.kr/learn/challenges