# Tugas Besar 2 IF2211 - Strategi Algoritme: <br> Pengaplikasian Algoritma BFS dan DFS dalam Fitur People You May Know Jejaring Sosial Facebook

## Deskripsi Tugas
Dalam tugas besar ini, Anda akan diminta untuk membangun sebuah aplikasi GUI sederhana yang dapat memodelkan beberapa fitur dari People You May Know dalam jejaring sosial media (Social Network). Dengan memanfaatkan algoritma Breadth First Search (BFS) dan Depth First Search (DFS), Anda dapat menelusuri social network pada akun facebook untuk mendapatkan rekomendasi teman seperti pada fitur People You May Know. Selain untuk mendapatkan rekomendasi teman, Anda juga diminta untuk mengembangkan fitur lain agar dua akun yang belum berteman dan tidak memiliki mutual friends sama sekali bisa berkenalan melalui jalur tertentu.
## Sekilas DFS dan BFS 
Traversal Graf, BFS, DFS
Graf merupakan representasi suatu persoalan sedangkan traversal graf merupakan pencarian solusi persoalan tersebut. Algoritma traversal graf yaitu mengunjungi simpul dengan cara yang sistematik. Algoritma traversal graf terbagi menjadi dua jenis:
 
Breadth First Search (BFS)
Breadth First Search adalah pencarian yang dilakukan secara melebar. Misalkan traversal dimulai dari simpul v, maka algoritma BFS sebagai berikut:
Kunjungi simpul v.
Kunjungi semua simpul yang bertetangga dengan simpul v terlebih dahulu.
Kunjungi simpul yang belum dikunjungi dan bertetangga dengan simpul-simpul yang tadi dikunjungi, demikian seterusnya.

Depth First Search (DFS)
Depth First Search adalah pencarian yang dilakukan secara mendalam. Misalkan traversal dimulai dari simpul v, maka algoritma DFS sebagai berikut:
Kunjungi simpul v.
Kunjungi simpul w yang bertetangga dengan simpul v.
Ulangi DFS mulai dari simpul w.
Ketika mencapai simpul u sedemikian sehingga semua simpul bertetangga dengannya telah dikunjungi, pencarian dirunut-balik (backtrack) ke simpul terakhir yang dikunjungi sebelumnya dan mempunyai simpul w yang belum dikunjungi.
Pencarian berakhir bila tidak ada lagi simpul yang belum dikunjungi yang dapat dicapai dari simpul yang telah dikunjungi.

## Requirement
Aplikasi berjalan di Windows, cukup jalankan bacefook.exe pada folder bin
Jika ingin melakukan perubahan/editing code, gunakan Visual Studio

## Cara Pengunaan
Cukup jalankan bacefook.exe pada folder bin

## Tentang Pembuat
<ul>
	<li>Leonardus Brandon Luwianto (13519102)
	<li>Nathaniel Jason (13519108)
	<li>Rizky Anggita Syarbaini Siregar (13519132)
</ul>