// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
// Output: 7 -> 0 -> 8
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        if(l1 == null)
            return l2;
        if(l2 == null)
            return l1;
        ListNode l1Ptr = l1;
        ListNode l2Ptr = l2;
        ListNode lastPtr = null;
        int carry = 0;
        while(l1Ptr != null) {
            int result = 0;
            result = l1Ptr.val + carry;
            if(l2Ptr != null) {
                result+= l2Ptr.val;
                l2Ptr = l2Ptr.next;
            }
            carry = result / 10;
            l1Ptr.val = result % 10;
            
            if(l1Ptr.next == null && l2Ptr != null) {
                l1Ptr.next = l2Ptr;
                l2Ptr = null;
            }
            lastPtr = l1Ptr;
            l1Ptr = l1Ptr.next;
        }
        if(carry > 0 && lastPtr != null){
            lastPtr.next = new ListNode(carry);
        }
        
        return l1;
    }
}