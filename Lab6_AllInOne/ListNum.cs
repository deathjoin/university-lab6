using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_AllInOne
{
    class ListNum
    {
        public int value;
        public ListNum next = null;
        public ListNum prev = null;
        public ListNum head = null;
        public ListNum tail = null;

        /**
         * Конструктор:
         * если createEmpty = true, то создается пустой список
         * иначе создается список с одним элементом, со значением val
         **/
        public ListNum(int val = 0, bool createEmpty = false) {
            if (!createEmpty) {
                this.value = val;
                this.head = this;
                this.tail = this;
            }
        }

        // Строковое представление списка
        public string getString() {
            string s;

            if (this.getLength() == 0) {
                s = "Список пуст";
            } else {
                s = "Список [" + getLength() + "]: \r\n";
                
                ListNum cur = this.head;

                while (cur != null) {
                    s += cur.value.ToString() + " ";
                    cur = cur.next;
                }
            }

            return s + "\r\n\r\n";
        }

        // Получение длины списка
        public int getLength() {
            ListNum cur = this.head;
            int i = 0;
            while (cur != null) {
                i++;
                cur = cur.next;
            }
            return i;
        }

        // Добавление в начало списка
        public void addToStart(int n) {
            ListNum x = new ListNum(n);

            // Если начало указывает куда-нибудь, то список не пуст, иначе добавляем как первый элемент
            if (this.head != null) {
                x.head = x;
                x.tail = this.tail;
                x.next = this.head;
                x.next.prev = x;
                this.head = x;
            } else {
                this.head = x;
                this.tail = x;
            }
        }

        // Добавление в конец списка
        public void addToEnd(int n) {
            ListNum x = new ListNum(n);

            // Если начало указывает куда-нибудь, то список не пуст, иначе добавляем как первый элемент
            if (this.head != null) {
                x.tail = x;
                x.head = this.head;
                x.prev = this.tail;
                x.prev.next = x;
                this.tail = x;
            } else {
                this.head = x;
                this.tail = x;
            }
        }

        // Добавление без нарушения порядка
        public void addToRightPlace(int n) {
            ListNum temp = this.head;

            while ((temp != null) && (n > temp.value)) {
                temp = temp.next;
            }

            // Если temp до сих пор указывает на начало..
            if (temp == head) {
                this.addToStart(n);
            // Если temp указывает на конец списка (вышел за пределы)
            } else if (temp == null) {
                this.addToEnd(n);
            // Иначе вставляем перед temp
            } else {
                ListNum x = new ListNum(n);
                temp.prev.next = x;
                x.prev = temp.prev;
                x.next = temp;
                temp.prev = x;
            }
        }
        /*
        // Сортировка слиянием
        public ListNum sortMerge(ListNum l = null) {
            ListNum left, right, result;
            int middle = 0,
                i = 0;

            // Если l никуда не указывает, то скажем, что хотит сортировать список, к которому обратились
            if (l == null) {
                l = this.head;
            }
            l = l.head;

            if (l.getLength() <= 1) {
                return l;
            } else {
                middle = l.getLength() / 2;

                // левая часть списка
                left = new ListNum(l.value);
                l = l.next;
                i++;
                while (i < middle) {
                    left.addToEnd(l.value);
                    l = l.next;
                    i++;
                }
                
                
                // правая часть списка
                right = new ListNum(l.value);
                l = l.next;
                while (l != null) {
                    right.addToEnd(l.value);
                    l = l.next;
                }               

                left = sortMerge(left);
                right = sortMerge(right);
                result = merge(left, right);

                return result;
            }
        }

        // Слияние
        private ListNum merge(ListNum l, ListNum r) {
            ListNum result = new ListNum(0, true);

            l = l.head;
            r = r.head;

            while ((l != null) && (r != null)) {
                if (l.value < r.value) {
                    result.addToEnd(l.value);
                    l = l.next;
                } else {
                    result.addToEnd(r.value);
                    r = r.next;
                }
            }

            while (l != null) {
                result.addToEnd(l.value);
                l = l.next;
            }
            while (r != null) {
                result.addToEnd(r.value);
                r = r.next;
            }

            return result;
        }*/

        //## Сортировка слиянием Ver. 2.0 ##\\
		
        public ListNum mergeSort(ListNum l = null, int count = -1) {
            
            if (l == null) {
                l = this.head;
                count = l.getLength();
            }

            ListNum left = l,
                    right,
                    cur = l;
            int mid = count / 2;
            
            left.head = l;
            
            for (int i = 1; i < mid; i++) {
                cur = cur.next;
            }
            right = cur.next;
            cur.next = null;

            left.tail = cur;

            right.prev = null;
            right.head = right;
            right.tail = l.tail;
            
            if (mid > 1) {
                left = mergeSort(left, mid);
            }
            if ((count - mid) > 1) {
                right = mergeSort(right, count-mid);
            }

            ListNum result;
            merge(left, right, out result);
            return result;
        }

        //## слияние ##\\
		
        private void merge(ListNum left, ListNum right, out ListNum resList) {
            ListNum cLeft, cRight, cur;
            cLeft = left;
            cRight = right;

            if (cLeft.value <= cRight.value) {
                resList = left;
                cur = cLeft;
                cLeft = cLeft.next;
            } else {
                resList = right;
                cur = cRight;
                cRight = cRight.next;
            }
            resList.head = resList;

            while ((cLeft != null) && (cRight != null)) {
                if (cLeft.value <= cRight.value) {
                    cur.next = cLeft;
                    cur.next.prev = cur;
                    cur = cLeft;
                    cLeft = cLeft.next;
                } else {
                    cur.next = cRight;
                    cur.next.prev = cur;
                    cur = cRight;
                    cRight = cRight.next;
                }
            }

            if (cLeft != null)  cur.next = cLeft;
            if (cRight != null) cur.next = cRight;
            
            // Востановление конца списка
            ListNum temp = cur.next;
            while (temp.next != null)
                temp = temp.next;
            resList.tail = temp;
        }

    }
}
